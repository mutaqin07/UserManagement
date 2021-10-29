using UserManagement.Application.Features.Brands.Commands.Create;
using UserManagement.Application.Features.Brands.Commands.Update;
using UserManagement.Application.Features.Brands.Queries.GetAllCached;
using UserManagement.Application.Features.Brands.Queries.GetById;
using UserManagement.Web.Areas.Catalog.Models;
using AutoMapper;

namespace UserManagement.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}