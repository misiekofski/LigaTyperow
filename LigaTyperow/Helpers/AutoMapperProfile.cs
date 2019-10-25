using AutoMapper;
using LigaTyperow.DTO;
using LigaTyperow.Models.Users;

namespace LigaTyperow.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}