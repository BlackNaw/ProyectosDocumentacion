using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaludoWebForm
{
    public partial class Saludo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            //Ocultamos el boton de la vista
            btnSaludar.Visible = false;
            //Cambio del texto del label
            lblSaludo.Text = "¡¡Hola Mundo!!"; 
        }
    }
}