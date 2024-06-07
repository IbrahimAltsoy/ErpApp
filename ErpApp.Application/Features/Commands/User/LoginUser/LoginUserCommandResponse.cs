using ErpApp.Domain.Dtos;

namespace ErpApp.Application.Features.Commands.LoginUser
{
    public class LoginUserCommandResponse
    {
        public Token Token { get; set; }
 
    }
    //public class LoginUserSuccessCommandResponse : LoginUserCommandResponse
    //{
    //    public Token Token { get; set; }
    //}
    //public class LoginUserErrorCommandResponse : LoginUserCommandResponse
    //{
    //    public string Message { get; set; }
    //}

}