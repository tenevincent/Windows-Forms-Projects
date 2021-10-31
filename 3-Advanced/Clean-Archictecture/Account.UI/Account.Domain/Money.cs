using System;
using System.Numerics;

namespace Account.Domain
{
    public struct Money
    {

        public static Money ZERO = default;


        private BigInteger amount;

        public  Money(int amount){


            }

        internal static Money Add(Money baselineBalance, object v)
        {
            throw new NotImplementedException();
        }

        internal object Negate()
        {
            throw new NotImplementedException();
        }

        internal bool IsPositiveOrZero()
        {
            throw new NotImplementedException();
        }
    }
}
