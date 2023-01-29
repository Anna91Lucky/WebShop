using Microsoft.AspNetCore.Mvc;
using ShopLearning.Models;
using AutoMapper;

namespace ShopLearning.Services
{
    public class MapperProfile : Profile
    {
        public MapperProfile()

        {
            CreateMap<BLL.Entity.Product, ProductModel>().ReverseMap();
        }
    }
}
