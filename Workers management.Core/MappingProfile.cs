using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.DTOs;
using Workers_management.Core.Entities;

namespace Workers_management.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.Date))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.Date))
                .ReverseMap();
            CreateMap<EmployeePosition, EmployeePotionsDto>().ReverseMap();
            CreateMap<Position, PotionDto>().ReverseMap();
        }
    }
}
