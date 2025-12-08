using DR_APIs.Models;
using DR_APIs.Utils;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Data;

namespace DR_APIs
{
    public static class Helpers
    {
        public static User GetUser(string APIKey, string email, MySqlConnection conn)
        {
            bool needsClosing = false;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                needsClosing = true;
            }

            string sql = "SELECT  APIKey, UserEmail, Role, pk FROM meetmanagers WHERE UserEmail = @email";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);

            DataTable dt = new DataTable();

            var _da = new MySqlDataAdapter(cmd);
            _da.Fill(dt);

            User u = new User();
            foreach (DataRow row in dt.Rows)
            {
                u.UserEmail = row["UserEmail"].ToString();
                u.Role = row["Role"].ToString();
                u.APIKey = row["APIKey"].ToString();
                u.pk = Int32.Parse(row["pk"].ToString());
            }

            // now verify the API key
            if (!PasswordHasher.Verify(APIKey, u.APIKey))
            {
                u = new Models.User(); // invalid, return empty user
            }
            u.APIKey = null; // do not return the API key

            if (needsClosing)
                conn.Close();
            return u;
        }

        public static bool UserExists(string email, MySqlConnection conn)
        {
            bool needsClosing = false;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                needsClosing = true;
            }

            string sql = "SELECT UserEmail FROM meetmanagers WHERE UserEmail = @email";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);

            DataTable dt = new DataTable();

            var _da = new MySqlDataAdapter(cmd);
            _da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                if (needsClosing)
                    conn.Close();
                return true;
            }
            else
            {
                if (needsClosing)
                    conn.Close();
                return false;
            }
        }



        public static bool IsAdmin(HttpRequest req,  MySqlConnection conn)
        {
            string managerpw = req.Headers["X-API-KEY"];
            string manageremail = req.Headers["X-API-ID"];
            var user = Helpers.GetUser(managerpw, manageremail, conn);
            if (user.pk != 0 && user.Role == "Admin")
            {
                return true;
            }
            return false;
        }


    }
}
