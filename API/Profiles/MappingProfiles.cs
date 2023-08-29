using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using AutoMapper;
using API.Dtos;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pais, PaisDto>().ReverseMap();

            CreateMap<Pais, PaisesDto>().ReverseMap();

            CreateMap<Estado, EstadoDto>().ReverseMap();
        }
    }
}