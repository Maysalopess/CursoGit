using AutoMapper;
using ReserveiAPI.Objects.DTO_s.Entities;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Objects.DTO_s.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        { 
            CreateMap<UserDTO , UserModel>().ReverseMap();
        }

    }
}
