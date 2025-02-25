using GAME.Domain.Entity;
using GAME.Domain.Repository;
using GAME.Service.Domain.Dtos;
using GAME.Service.Domain.Mappers.Players;
using GAME.Service.Domain.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Service.Domain.Login
{
    public class LoginDomainService : ILoginDomainService
    {
        private readonly ILogin _login;
        public LoginDomainService(ILogin login)
        {
            _login = login;
        }
        public bool GetLogin(PlayerDto playerDto)
        {
            Player player = PlayerMap.MapToPlayer(playerDto); 
            return _login.GetLogin(player);
        }
    }
}
