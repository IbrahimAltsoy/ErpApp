using ErpApp.Domain.Dtos;

namespace ErpApp.Application.Services
{
    public interface IAuthService
    {
        Task<Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<Token> RefreshTokenLoginAsync(string refreshToken);
    }
}
