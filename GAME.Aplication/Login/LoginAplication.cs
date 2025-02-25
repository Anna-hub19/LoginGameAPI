using GAME.Service.Domain.Dtos;
using GAME.Service.Domain.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Aplication.Login
{
    public class LoginAplication : ILoginAplication
    {
        private readonly ILoginDomainService _loginDomainService;
        public LoginAplication(ILoginDomainService loginDomainService)
        {
            _loginDomainService = loginDomainService;
        }
        public bool GetLogin(PlayerDto playerDto)
        {
          return  _loginDomainService.GetLogin(playerDto);
        }
    }
}
