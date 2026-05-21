using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI.WebControls;

namespace TP6_Grupo19_2_
{
    public class AccesoNeptuno
    {

        private const string rutaNeptuno = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection sqlConecction = new SqlConnection(rutaNeptuno);

            try
            {
                sqlConecction.Open();
                return sqlConecction;
            }
            catch
            {
                return null;
            }
        }

        public DataTable EjecutarSelect(string consultaSQL)
        {
            SqlCommand command = new SqlCommand(consultaSQL, ObtenerConexion()); // PASAMOS LA CONSULTA Y EL OBJETO CONEXION

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command); // CREAMOS dataAdapter CON EL SELECT

            DataTable dataTable = new DataTable(); // CREAMOS dataTable PARA PASAR AL dataAdapter

            dataAdapter.Fill(dataTable); // LLENAMOS EL dataTable A TRAVES DEL METODO .fill DE dataAdapter

            return dataTable;
        }




}
}