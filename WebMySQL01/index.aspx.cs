using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMySQL01
{
    public partial class index : System.Web.UI.Page
    {
        DBconnect ligacao = new DBconnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblNFormandos.Text = ligacao.Count().ToString();
            if (!Page.IsPostBack)
            {
                ligacao.bind(ref GridView1);
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormInsert.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormUpdate.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormDelete.aspx");
        }

        public double CalcularMedia(GridView gv1)
        {
            double media = 0;
            int numFormandos = gv1.Rows.Count;

            // Verifica se há pelo menos um formando na tabela
            if (numFormandos > 0)
            {
                int somaIdades = 0;

                // Percorre as linhas do GridView e soma as idades
                for (int i = 0; i < numFormandos; i++)
                {
                    GridViewRow row = gv1.Rows[i];
                    int idade = Convert.ToInt32(row.Cells[3].Text); // obtém a idade na quarta coluna
                    somaIdades += idade;
                }

                // Calcula a média das idades
                media = somaIdades / (double)numFormandos;
            }

            return media;
        }

        protected void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            // Chama a função para calcular a média e atribui o resultado ao texto do Label
            lblMedia.Text = CalcularMedia(GridView1).ToString();
        }
    }
}
