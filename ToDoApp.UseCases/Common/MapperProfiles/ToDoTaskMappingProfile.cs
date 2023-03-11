using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities.Models;
using ToDoApp.UseCases.Features.ToDoTasks.Queries.GetSingleToDoTask;

namespace ToDoApp.UseCases.Common.MapperProfiles
{
    public class ToDoTaskMappingProfile : Profile
    {
        public ToDoTaskMappingProfile()
        {
            CreateMap<ToDoTask, ToDoTaskDto>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.Deadline));
        }
    }
}
