using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.App.Services.Profiles
{
	// This is the approach starting with version 5
	public class OrderProfile : Profile
	{
		public OrderProfile()
		{
			CreateMap<Order, OrderDto>();	
			// Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
		}
	}
}
