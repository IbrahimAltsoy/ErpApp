using ErpApp.Application.Services;
using ErpApp.Application.Services.HubService;
using ErpApp.Domain.Dtos.Users;
using MediatR;

namespace ErpApp.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;
        readonly ICreateUserHubService _createUserHubService;
        public CreateUserCommandHandler(IUserService userService, ICreateUserHubService createUserHubService)
        {
            _userService = userService;
            _createUserHubService = createUserHubService;
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
            await _createUserHubService.SendMessage($"{request.Username} - {response.Message}");
            return new()
            {
                Message = response.Message
            };
            
        }
    }
}
