﻿using ErpApp.Application.Services;
using ErpApp.Application.Services.HubService;
using ErpApp.Domain.Dtos.Users;
using MediatR;

namespace ErpApp.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;       
        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
            
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
                Email = request.Email,
                NameSurname = request.NameSurname,
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm,
                Username = request.Username,
            });            
            return new()
            {
                Message = response.Message
            };
            
        }
    }
}
