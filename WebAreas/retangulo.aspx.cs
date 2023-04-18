using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAreas
{
    public partial class retangulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        protected void Btncalcular_Click(object sender, EventArgs e)
        {

            try
            {

                lblResultado.Text = (float.Parse("0" + txtLargura.Text) * float.Parse("0" + txtComprimento.Text)).ToString();
                if (txtComprimento.Text == txtLargura.Text){
                    lblResultado.Text = lblResultado.Text + "mas este é um quadrado";

                }
            }
            catch 
            {
                lblResultado.Text = "Erro!";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}