using GAME.Domain.Entity;
using GAME.Domain.Repository;
using GAME.Infra.ConnectionDb;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Infra.Repository
{
    public class Login : ILogin
    {
        private ConnectionDB _connectionString;
        public Login(IConfiguration configuration)
        {
            _connectionString = new ConnectionDB(configuration);
        }
        bool ILogin.GetLogin(Player player)
        {
            using var conn = new NpgsqlConnection(_connectionString.GetString());
            conn.Open();

            string query = "SELECT COUNT(*) FROM player WHERE nome = @nome AND senha = @senha";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("nome", player.Name);
            cmd.Parameters.AddWithValue("senha", player.Senha); 

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }
    }
}
