﻿using AutoMapper;
using BitBasket.Core.DTO;
using BitBasket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core.Mappers
{
    public class ApplicationUserMappingProfile : Profile
    {
        public ApplicationUserMappingProfile()
        {
            CreateMap<ApplicationUser, AuthenticationResponse>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId));
            CreateMap<ApplicationUser, AuthenticationResponse>()
               .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName));
            CreateMap<ApplicationUser, AuthenticationResponse>()
               .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            CreateMap<ApplicationUser, AuthenticationResponse>()
               .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender));
            CreateMap<ApplicationUser, AuthenticationResponse>()
               .ForMember(dest => dest.Token, opt => opt.Ignore());
            CreateMap<ApplicationUser, AuthenticationResponse>()
               .ForMember(dest => dest.success, opt => opt.Ignore());
        }
    }
}
