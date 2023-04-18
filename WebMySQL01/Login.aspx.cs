using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebMySQL01
{
    public partial class Login : System.Web.UI.Page
    {
        private string connectionString = "Server=grandeporto.ddns.net;Port=3306;Database=Prog22094;Uid=User22094;Pwd=AspNET2023!;";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // obter as credenciais do usuário
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // verificar se o usuário e a senha correspondem a um registro válido no banco de dados
            bool isValidUser = AuthenticateUser(username, password);

            if (isValidUser)
            {

                



                // usuário autenticado com sucesso, redirecionar para a página de destino
                Response.Redirect("index.aspx");
            }
            else
            {
                // credenciais inválidas, exibir uma mensagem de erro
                lblError.Text = "Usuário ou senha inválidos.";
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM users WHERE username='{username}' AND password='{password}'";
                SqlCommand command = new SqlCommand(query, conn);
                int result = (int)command.ExecuteScalar();
                return result > 0;
            }
        }
    }
}
