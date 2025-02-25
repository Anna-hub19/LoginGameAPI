using GAME.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Domain.Repository
{
    public interface ILogin
    {
        public bool GetLogin(Player player);
    }
}
