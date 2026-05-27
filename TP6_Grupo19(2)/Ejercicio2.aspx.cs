using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_Grupo19_2_
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }        
        

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Session["tablaProductos"] = null;

            lblMensaje.Text = "SE ELIMINO LA SELECCION";
        }

    }

}