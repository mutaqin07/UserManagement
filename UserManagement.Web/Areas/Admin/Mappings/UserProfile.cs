using UserManagement.Infrastructure.Identity.Models;
using UserManagement.Web.Areas.Admin.Models;
using AutoMapper;

namespace UserManagement.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}