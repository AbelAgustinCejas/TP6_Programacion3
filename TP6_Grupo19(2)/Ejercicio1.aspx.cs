using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo19_2_
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        private void CargarGridView()
        {
            AccesoNeptuno conexion = new AccesoNeptuno(); // EJECUTAMOS CONEXION

            string consultaSQL = "SELECT * FROM Productos"; // DEFINIMOS CONSULTA

            DataTable dataTable = conexion.EjecutarSelect(consultaSQL); // LLENAMOS dataTable 

            gvProductos.DataSource = dataTable; // ASIGNAMOS FUENTE
            gvProductos.DataBind(); // MOSTRAMOS UNA VEZ ASIGNAMOS 
        }
    }
}