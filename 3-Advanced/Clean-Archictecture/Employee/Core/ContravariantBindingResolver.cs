﻿using global::Ninject.Infrastructure;
using global::Ninject.Planning.Bindings;
using global::Ninject.Planning.Bindings.Resolvers;
using Ninject.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;



namespace Core
{
    public class ContravariantBindingResolver : NinjectComponent, IBindingResolver
    {
        /// <summary>
        /// Returns any bindings from the specified collection that match the specified service.
        /// </summary>
        public IEnumerable<IBinding> Resolve(Multimap<Type, IBinding> bindings, Type service)
        {
            if (service.IsGenericType)
            {
                var genericType = service.GetGenericTypeDefinition();
                var genericArguments = genericType.GetGenericArguments();
                if (genericArguments.Count() == 1
                 && genericArguments.Single().GenericParameterAttributes.HasFlag(GenericParameterAttributes.Contravariant))
                {
                    var argument = service.GetGenericArguments().Single();
                    var matches = bindings.Where(kvp => kvp.Key.IsGenericType
                                                           && kvp.Key.GetGenericTypeDefinition().Equals(genericType)
                                                           && kvp.Key.GetGenericArguments().Single() != argument
                                                           && kvp.Key.GetGenericArguments().Single().IsAssignableFrom(argument))
                        .SelectMany(kvp => kvp.Value);
                    return matches;
                }
            }

            return Enumerable.Empty<IBinding>();
        }
    }
}
