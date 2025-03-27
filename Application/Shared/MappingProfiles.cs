using AutoMapper;
using Domain;

namespace Application.Shared;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
    }
}