using UserManagement.Application.Features.Products.Commands.Create;
using UserManagement.Application.Features.Products.Queries.GetAllCached;
using UserManagement.Application.Features.Products.Queries.GetAllPaged;
using UserManagement.Application.Features.Products.Queries.GetById;
using UserManagement.Domain.Entities.Catalog;
using AutoMapper;

namespace UserManagement.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}