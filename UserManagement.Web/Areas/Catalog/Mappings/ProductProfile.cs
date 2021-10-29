using UserManagement.Application.Features.Products.Commands.Create;
using UserManagement.Application.Features.Products.Commands.Update;
using UserManagement.Application.Features.Products.Queries.GetAllCached;
using UserManagement.Application.Features.Products.Queries.GetById;
using UserManagement.Web.Areas.Catalog.Models;
using AutoMapper;

namespace UserManagement.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}