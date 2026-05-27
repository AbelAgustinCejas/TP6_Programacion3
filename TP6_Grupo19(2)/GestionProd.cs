using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace TP6_Grupo19_2_
{
    public class GestionProd
    {

        string conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";

        public void EliminarProducto(int idProducto)
        {
            SqlConnection con = new SqlConnection(conexion);

            string query = "DELETE FROM Productos WHERE IdProducto=@id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", idProducto);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }


        public void ActualizarProducto(int idProducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad)
        {
            AccesoNeptuno acceso = new AccesoNeptuno();

            SqlConnection conexion = acceso.ObtenerConexion();

            string consulta =

                "UPDATE Productos SET " +
                "NombreProducto = @nombre, " +
                "CantidadPorUnidad = @cantidad, " +
                "PrecioUnidad = @precio " +
                "WHERE IdProducto = @id";

            SqlCommand command = new SqlCommand(consulta, conexion);

            command.Parameters.AddWithValue("@nombre", nombreProducto);
            command.Parameters.AddWithValue("@cantidad", cantidadPorUnidad);
            command.Parameters.AddWithValue("@precio", precioUnidad);
            command.Parameters.AddWithValue("@id", idProducto);

            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
