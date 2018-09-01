using AutoMapper;
using RentAHousband.Dtos;
using RentAHousband.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentAHousband.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
        }
    }
}