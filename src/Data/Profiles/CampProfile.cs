using AutoMapper;
using CoreCodeCamp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data.Profiles
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(cm=> cm.VenueName, o => o.MapFrom(m => m.Location.VenueName))
                .ForMember(cm=> cm.Address1, o => o.MapFrom(m => m.Location.Address1))
                .ForMember(cm=> cm.Address2, o => o.MapFrom(m => m.Location.Address2))
                .ForMember(cm=> cm.Address3, o => o.MapFrom(m => m.Location.Address3))
                .ForMember(cm=> cm.CityTown, o => o.MapFrom(m => m.Location.CityTown))
                .ForMember(cm=> cm.StateProvince, o => o.MapFrom(m => m.Location.StateProvince))
                .ForMember(cm=> cm.PostalCode, o => o.MapFrom(m => m.Location.PostalCode))
                .ForMember(cm=> cm.Country, o => o.MapFrom(m => m.Location.Country));
        }       
    }
}
