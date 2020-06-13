using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Models;
using Task1.ViewModels;

namespace Task1.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, PropertyViewModel>()
                 .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(x => x.Owner.Name))
                    .ForMember(dest => dest.OwnerFamily, opt => opt.MapFrom(x => x.Owner.Family))
                   
                      .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.Owner.Name + " " + x.Owner.Family))
                 .ReverseMap();
            CreateMap<Owner, OwnerViewModel>()
                 .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.Name+" "+x.Family))
                   
                 .ReverseMap();
          
        }
    }
}
