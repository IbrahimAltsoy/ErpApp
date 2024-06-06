using ErpApp.Domain.Dtos;
using ErpApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpApp.Application.Services
{
    public interface ITokenService
    {
        Token CreateAccessToken(int second, User appUser);
        string CreateRefreshToken();
    }
}
