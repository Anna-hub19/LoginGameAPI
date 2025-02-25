using GAME.Aplication.Login;
using GAME.Service.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GAME.API.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class PlayerController : Controller
    {
        private readonly ILoginAplication _loginAplication;
       
        
        public PlayerController(ILoginAplication loginAplication)
        {
            _loginAplication = loginAplication;
        }


        [HttpPost("login")]
        public IActionResult LoginPlayer([FromBody] PlayerDto playerDto)
        {
            if (playerDto == null || string.IsNullOrEmpty(playerDto.Name) || string.IsNullOrEmpty(playerDto.Senha))
            {
                return BadRequest("Nome e senha são obrigatórios.");
            }

            bool loginValido = _loginAplication.GetLogin(playerDto);

            if (loginValido)
            {
                return Ok(new { mensagem = "Login feito com sucesso" });
            }

            return Unauthorized("Nome ou senha inválidos.");
        }

    }
}
