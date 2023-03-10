﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities.Models;

namespace ToDoApp.UseCases.Account.Commands.RegisterUser
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisterUserCommandResult>
    {
        public UserManager<User> _userManager;

        public RegisterUserCommandHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<RegisterUserCommandResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                Email= request.Email,
                UserName= request.UserName,
            };

            var createResult = await _userManager.CreateAsync(user, request.Password);

            var registerResult = new RegisterUserCommandResult()
            {
                IsSuccessed = createResult.Succeeded,
                Errors = createResult.Errors.Select(er => er.Description)
            };

            return registerResult;
        }
    }
}