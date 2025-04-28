using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sol_Minimarket.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "BD_MINIMARKET";
            this.Servidor = "DESKTOP-8RKDIL4\\SQLEXPRESS";
            this.Usuario = "sistemas";
            this.Clave = "soporte";
            this.Seguridad = false;
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base + ";User Id=" + this.Usuario + ";Password=" + this.Clave + ";Integrated Security=" + this.Seguridad + ";";
            return cn;
        }
    }
}