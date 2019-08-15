using AutoMapper;
using ProjectBuilder.Application.Dtos.Project;
using ProjectBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Project, ProjectDto>()
                    .ForMember(dest => dest.AmountRisedPercent, opt => opt.MapFrom(src => decimal.Round((src.DonatedAmount / src.Amount * 100).GetValueOrDefault(), 1, MidpointRounding.AwayFromZero)))
                    .ForMember(dest => dest.RisedAmount, opt => opt.MapFrom(src => src.DonatedAmount.GetValueOrDefault()))
                    .ForMember(dest => dest.SponsorsCount, opt => opt.MapFrom(src => src.DonationsCount.GetValueOrDefault()));
        }
    }
}
