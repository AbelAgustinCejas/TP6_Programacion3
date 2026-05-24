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

            gvProductos.DataSource = dataTable; 
            gvProductos.DataBind(); 
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            /// Obtenemos id de la seleccion del usuario
            //int idProducto = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Value);
            int idProducto = Convert.ToInt32(((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text);

            /// LLamamos al metodo de la clase GestionProd para eliminar el producto
            GestionProd gestora = new GestionProd();
            /// Eliminamos el producto
            gestora.EliminarProducto(idProducto);

            CargarGridView();
        }
        

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }
    }
}