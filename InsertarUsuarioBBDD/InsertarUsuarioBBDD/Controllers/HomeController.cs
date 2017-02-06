using MySql.Data.MySqlClient;
using System.Configuration;
using System.Web.Mvc;

namespace InsertarUsuarioBBDD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult InsertarUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertarUsuario(string Nick, string Pass)
        {
            string sql = "INSERT INTO usuario(nick, pass) VALUES('"+Nick+"', '"+Pass+"')";
            MySqlConnection connection = AbrirConexion();
            MySqlCommand comando = new MySqlCommand(sql,connection);
            comando.ExecuteNonQuery();
            return View();
        }

        public static MySqlConnection AbrirConexion()
        {
            MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString =
                        "Server=localhost;Database=insertarBase;Uid=root;Pwd=''";
                    connection.Open();
            return connection;
        }
    }
}