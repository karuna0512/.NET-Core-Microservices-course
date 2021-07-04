using AutoMapper;
using Mango.Services.ShoppingCartAPI.Models;
using Mango.Services.ShoppingCartAPI.Models.Dto;
//using Mango.Services.ShoppingCartAPI.Models;
//using Mango.Services.ShoppingCartAPI.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config => {
                    config.CreateMap<ProductDto, Product>().ReverseMap();
                    config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
                    config.CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
                    config.CreateMap<CartDto, Cart>().ReverseMap();
                });
            return mappingConfig;
        }
    }
}
