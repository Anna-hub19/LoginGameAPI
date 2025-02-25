using GAME.Domain.Entity;
using GAME.Service.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Service.Domain.Login
{
    public interface ILoginDomainService
    {
        public bool GetLogin(PlayerDto playerDto);
    }
}
