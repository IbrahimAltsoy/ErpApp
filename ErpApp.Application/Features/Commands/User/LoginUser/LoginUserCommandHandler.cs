using ErpApp.Application.Services;
using ErpApp.Application.Services.HubService;
using MediatR;

namespace ErpApp.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IAuthService _authService;
        readonly ILoginUserHubService _loginUserHubService;

        public LoginUserCommandHandler(IAuthService authService, ILoginUserHubService loginUserHubService)
        {
            _authService = authService;
            _loginUserHubService = loginUserHubService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.LoginAsync(request.UsernameOrEmail, request.Password, 900);
            if (token!=null)
            {
                await _loginUserHubService.SendMessage($"{request.UsernameOrEmail}- kullanıcı başarılı giriş yaptı.");
            }
            
            return new LoginUserSuccessCommandResponse()
            {
                Token = token
            };
        }
    }
}
