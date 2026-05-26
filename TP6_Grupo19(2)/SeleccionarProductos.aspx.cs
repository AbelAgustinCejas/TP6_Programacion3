using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_Grupo19_2_;

namespace TP6_Grupo19_2_
{
    public partial class SeleccionarProductos : System.Web.UI.Page
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
        private DataTable CrearTabla()
        {
            DataTable dataTable = new DataTable();

            DataColumn dataColumn;

            dataColumn = new DataColumn("Id Producto", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Nombre Producto", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Cantidad Por Unidad", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Precio Unidad", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);

            return dataTable;
        }


        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }


        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProducto_Seleccionado.Text = ((Label)gvProductos.SelectedRow.FindControl("lbl_it_NombreProducto")).Text;
            lblProducto_Seleccionado.Visible = true;
        }

    }
}

