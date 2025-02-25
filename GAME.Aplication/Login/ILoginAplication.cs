using GAME.Service.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Aplication.Login
{
    public interface ILoginAplication
    {
        public bool GetLogin(PlayerDto playerDto);
    }
}
