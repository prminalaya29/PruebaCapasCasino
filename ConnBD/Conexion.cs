using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnBD
{
    public class Conexion
    {
        public string SQLServer()
        {
            //se prepara la conexión
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "192.168.3.39"; //se define el nombre del servidor
            builder.InitialCatalog = "Millennium_SistWings-Salas"; //se define el nombre 
            builder.UserID = "rodrigo"; //se define el nombre del usuario
            builder.Password = "72257350"; //se define el password               

            return builder.ToString();

        }

    }
}
