using DR_APIs.Models;
using DR_APIs.Utils;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;

namespace DR_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        private readonly IConfiguration _config;
        private string ConnectionString;
        MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();

        public UserController(IConfiguration configuration)
        {
            _config = configuration;
            ConnectionString = _config["MysqlConStr"];
            conn.ConnectionString = ConnectionString;
        }

 
        [HttpGet("GetUser")]
        public  User GetUser(string APIKey, string email)
        {
            Console.WriteLine("Got Auth request for " + email);
            return Helpers.GetUser(APIKey, email, conn);
        }

        [HttpGet("UserExists")]
        public bool UserExists(string email)
        {
            return Helpers.UserExists(email, conn);
        }


        [HttpGet("UpdateUser")]
        public ActionResult<bool> UpdateUser(string APIKey, string email)
        {
            if (!Helpers.IsAdmin(Request,  conn))
            {
                return Unauthorized("Unauthorized access, you do not have permission to manage Users");
            }

            Console.WriteLine("Got Request to UpdateUser for " + Request.Headers["X-API-ID"]);
            return UpdateUser(APIKey, email, conn);
        }

        [HttpGet("CreateUser")]
        public ActionResult<bool> CreateUser(string APIKey, string email)
        {
            if (!Helpers.IsAdmin(Request, conn))
            {
                return Unauthorized("Unauthorized access, you do not have permission to manage Users");
            }

            Console.WriteLine("Got Request to UpdateUser for " + Request.Headers["X-API-ID"]);
            return CreateUser(APIKey, email, conn);
        }

        public static bool CreateUser(string APIKey, string email, MySqlConnection conn)
        {
            try
            {
                bool needsClosing = false;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    needsClosing = true;
                }

                string sql = "INSERT INTO meetmanagers (APIKey, UserEmail, Role) VALUES (@apikey, @email, @role)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@apikey", PasswordHasher.Hash(APIKey));
                cmd.Parameters.AddWithValue("@role", "Manager");

                cmd.ExecuteNonQuery();

                if (needsClosing)
                    conn.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }
        }

        public static bool UpdateUser(string APIKey, string email, MySqlConnection conn)
        {
            try
            {
                bool needsClosing = false;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    needsClosing = true;
                }

                if (!Helpers.UserExists(email, conn))
                {
                    return false;
                }

                string sql = "UPDATE meetmanagers SET  APIKey=@apikey WHERE  UserEmail = @email;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@apikey", PasswordHasher.Hash(APIKey));
                cmd.Parameters.AddWithValue("@role", "Manager");

                cmd.ExecuteNonQuery();

                if (needsClosing)
                    conn.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }
        }

    }
}
