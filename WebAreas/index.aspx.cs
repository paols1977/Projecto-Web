using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAreas
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetangulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("retangulo.aspx");
        }

        protected void btnQuadrado_Click(object sender, EventArgs e)
        {
            Response.Redirect("Quadrado.aspx");
        }

        protected void btnCirculo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Circulo.aspx");
        }

        protected void btnTriangulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Triangulo.aspx");
        }
    }
}