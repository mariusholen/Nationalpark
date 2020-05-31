using System;
using AutoMapper;
using ParkyAPI.Models;
using ParkyAPI.Models.DTO;

namespace ParkyAPI.ParkyMapper
{
    public class ParkyMappings : Profile
    {
        public ParkyMappings()
        {
            CreateMap<NationalPark, NationalParkDTO>().ReverseMap();
            CreateMap<Trail, TrailDTO>().ReverseMap();
            CreateMap<Trail, TrailUpsertDTO>().ReverseMap();
        }
    }
}
