using UserManagement.Application.Features.Brands.Commands.Create;
using UserManagement.Application.Features.Brands.Queries.GetAllCached;
using UserManagement.Application.Features.Brands.Queries.GetById;
using UserManagement.Domain.Entities.Catalog;
using AutoMapper;

namespace UserManagement.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}