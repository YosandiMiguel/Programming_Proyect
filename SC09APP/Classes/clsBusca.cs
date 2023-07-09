using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace SC09APP
{
    public class cnn
    {
        public static string db = @"Server=DESKTOP-TFVTCNK\SQLEXPRESS;Database=DBpractica04;Trusted_Connection=True";
    }

    public class Usuario
    {
        public static string nombre { get; set; }
        public static string correo { get; set; }
        public static string cargo { get; set; }
        public static int Id { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string _name, int _value)
        {
            Name = _name;
            Value = _value;
        }

        public override string ToString()
        {
            return Name;
        }
    }


    public class Busco
    {
        public static string Fabricas(string numFabrica)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("SELECT IDFABRICA, NOMBREDEFABRICA " +
                                              "  FROM FABRICA " +
                                              " WHERE IDFABRICA = @PV", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", numFabrica);
            SqlDataReader rsd = cmmnd.ExecuteReader();

            if (rsd.Read())
            {
                return Convert.ToString(rsd["NOMBREDEFABRICA"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Clientes(string numCliente)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("SELECT IDCLIENTE, NOMBRE " +
                                              "  FROM CLIENTES " +
                                              " WHERE IDCLIENTE = @PV", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", numCliente);
            SqlDataReader rsd = cmmnd.ExecuteReader();

            if (rsd.Read())
            {
                return Convert.ToString(rsd["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string UsuariosSistema(string nameUsuario)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmnd = new SqlCommand("SELECT NUMEROEMPLEADO, NOMBRECORTO, NOMBREUSUARIO, ACTIVO, ID, CORREO, CARGO " +
                                             "  FROM USUARIO " +
                                             " WHERE ACTIVO = 'TRUE' " +
                                             "   AND NOMBRECORTO = @PV", cnxn);
            cmnd.Parameters.AddWithValue("@PV", nameUsuario);
            SqlDataReader datos = cmnd.ExecuteReader();

            if (datos.Read())
            {
                Usuario.nombre = Convert.ToString(datos["NOMBREUSUARIO"]);
                Usuario.cargo = Convert.ToString(datos["CARGO"]);
                Usuario.correo = Convert.ToString(datos["CORREO"]);
                Usuario.Id = Convert.ToInt32(datos["ID"]);

                return Convert.ToString(datos["CLAVE"]);
            }

            cmnd.Dispose();
            cnxn.Close();
            return null;
        }
    }
}
