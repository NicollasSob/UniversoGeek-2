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
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Address, AddressViewModel>()
                .ReverseMap();
            CreateMap<Client, ClientViewModel>()
                .ReverseMap();
            CreateMap<OrderItem, OrderItemViewModel>()
                .ReverseMap();

            CreateMap<Order, OrderViewModel>();

            CreateMap<Product, ProductViewModel>()
                .ReverseMap();
            CreateMap<Voucher, VoucherViewModel>()
                .ReverseMap();
            CreateMap<Category, CategoryViewModel>()
                .ReverseMap();
        }
    }
}
