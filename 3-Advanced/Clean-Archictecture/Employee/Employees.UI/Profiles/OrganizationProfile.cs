using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.UI.Profiles
{
	// This is the approach starting with version 5
	public class OrganizationProfile : Profile
	{
		public OrganizationProfile()
		{
			CreateMap<Foo, FooDto>();	
			// Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
		}
	}
}
