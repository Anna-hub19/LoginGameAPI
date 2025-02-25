using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME.Domain.Entity;
using GAME.Service.Domain.Dtos;

namespace GAME.Service.Domain.Mappers.Players
{
    public static class PlayerMap
    {
        public static Player MapToPlayer(this PlayerDto playerDto)
        {
            return new Player
            {
                Name = playerDto.Name,
                Senha = playerDto.Senha
            };
        }
    }
}
