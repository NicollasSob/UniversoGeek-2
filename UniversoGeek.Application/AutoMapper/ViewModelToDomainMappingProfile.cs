using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Application.ViewModel;
using UniversoGeek.Domain.Entities;

namespace UniversoGeek.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<OrderViewModel, Order>()
                .ForMember(dest => dest.AddressId, opt => opt.MapFrom(map => map.Address.Id));
        }
    }
}
