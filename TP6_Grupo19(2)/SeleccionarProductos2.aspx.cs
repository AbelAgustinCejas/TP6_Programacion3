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
    public partial class SeleccionarProductos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            GestionProd gestora =  new GestionProd();

            gvProductos.DataSource =   gestora.ListarProductos();

            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(
            object sender,
            GridViewPageEventArgs e)
        {
            gvProductos.PageIndex =
                e.NewPageIndex;

            CargarProductos();
        }

        protected void gvProductos_SelectedIndexChanging(
            object sender,
            GridViewSelectEventArgs e)
        {
            string nombre =
                gvProductos.Rows[e.NewSelectedIndex]
                .Cells[2]
                .Text;
        }
    }
}