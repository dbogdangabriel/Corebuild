using AutoMapper;
using CourseLibrary.API.Helper;

namespace CourseLibrary.API.Profiles
{
    public class AuthorsProfiles: Profile 
    {
        public AuthorsProfiles()
        {
            CreateMap<Entities.Author, Models.AuthorDto>()
                .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                dest => dest.Age,
                opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
            CreateMap<Models.AuthorForCreationDto, Entities.Author>();

        }
    }
}
