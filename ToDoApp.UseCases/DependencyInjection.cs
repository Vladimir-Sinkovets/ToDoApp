using MediatR;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using ToDoApp.UseCases.Common.Behaviors;
using ToDoApp.UseCases.Account.Commands.RegisterUser;

namespace ToDoApp.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
