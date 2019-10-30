using AutoMapper;
using LigaTyperow.Entities;
using LigaTyperow.Models.Users;

namespace LigaTyperow.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}