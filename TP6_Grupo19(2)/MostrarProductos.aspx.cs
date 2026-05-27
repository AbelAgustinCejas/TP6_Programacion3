using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo19_2_
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["tablaProductos"] != null)
                {
                    gvProductos.DataSource = Session["tablaProductos"];
                    gvProductos.DataBind();
                }
                else
                {
                    lblMensaje.Text = "No hay productos seleccionados";
                }

            }
        }

        protected void volverinicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }

    }
}
    
