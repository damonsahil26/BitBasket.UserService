using AutoMapper;
using BitBasket.Core.DTO;
using BitBasket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core.Mappers
{
    public class RegisterUserMappingProfile : Profile
    {
        public RegisterUserMappingProfile()
        {
            CreateMap<RegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.UserId, opt => opt.Ignore());
            CreateMap<RegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            CreateMap<RegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));
            CreateMap<RegisterRequest, ApplicationUser>()
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src=>src.PersonName));
            CreateMap<RegisterRequest, ApplicationUser>()
               .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender));
        }
    }
}
