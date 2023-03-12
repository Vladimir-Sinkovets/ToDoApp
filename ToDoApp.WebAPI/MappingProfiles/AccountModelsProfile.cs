using AutoMapper;
using ToDoApp.UseCases.Features.Account.Commands.RegisterUser;
using ToDoApp.UseCases.Features.Account.Commands.SignIn;
using ToDoApp.WebAPI.Models.Account;

namespace ToDoApp.WebAPI.MappingProfiles
{
    public class AccountModelsProfile : Profile
    {
        public AccountModelsProfile()
        {
            CreateMap<RegisterModel, RegisterUserCommand>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));

            CreateMap<RegisterModel, SignInCommand>()
                .ForMember(dest => dest.IsPersistent, opt => opt.MapFrom(src => src.IsPersistent))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));

            CreateMap<LoginModel, SignInCommand>()
                .ForMember(dest => dest.IsPersistent, opt => opt.MapFrom(src => src.IsPersistent))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));
        }
    }
}
