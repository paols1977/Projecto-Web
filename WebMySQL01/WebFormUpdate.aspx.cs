using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebMySQL01
{
    public partial class WebFormUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Carregar todos os formandos no dropdownlist
                DBconnect db = new DBconnect();
                db.CarregarFormandos(ref DropDownList1);

                // Verificar se há um parâmetro de consulta "id" na URL
                string id = Request.QueryString["id"];

                if (id != null)
                {
                    // Se houver, carregar as informações do formando com esse ID
                    string nome = "";
                    char genero = ' ';
                    int idade = 0;

                    bool resultado = db.DevolverFormando(id, ref nome, ref genero, ref idade);

                    if (resultado)
                    {
                        TextBox3.Text = nome;
                        DropDownList3.SelectedValue = genero.ToString();
                        TextBox4.Text = idade.ToString();
                        Label2.Text = "";
                    }
                    else
                    {
                        Label8.Text = "Erro ao carregar formando.";
                    }
                }
                else
                {
                    // Limpar a mensagem de sucesso se não houver um parâmetro de consulta "id" na URL
                    Label8.Text = "";
                }
            }
        }








        public void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox5.Text);

            DBconnect db = new DBconnect();
            bool connected = db.OpenConnection();

            if (connected)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT nome, genero, idade FROM formando WHERE id=@id", db.GetConnection());

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TextBox3.Text = reader["nome"].ToString();
                    DropDownList3.SelectedValue = reader["genero"].ToString();
                    TextBox4.Text = reader["idade"].ToString();
                }
                else
                {
                    Label8.Text = "Formando não encontrado.";
                }
                
                 db.CloseConnection();
            }
            else
            {
                Label8.Text = "Erro na conexão com o banco de dados.";
            }
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            string nome = TextBox1.Text;
            char genero = Char.Parse(DropDownList2.SelectedValue);
            string idade = TextBox2.Text;

            DBconnect db = new DBconnect();
            bool resultado = db.Insert(nome, genero, idade);

            if (resultado)
            {
                Label8.Text = "Formando adicionado com sucesso.";
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList2.SelectedIndex = 0;
                DropDownList1.Items.Clear();
                db.CarregarFormandos(ref DropDownList1);
            }
            else
            {
                Label8.Text = "Erro ao adicionar formando.";
            }
        }

        




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue.Split('-')[0].Trim();

            DBconnect db = new DBconnect();

            string nome = "";
            char genero = ' ';
            int idade = 0;

            bool resultado = db.DevolverFormando(id, ref nome, ref genero, ref idade);

            if (resultado)
            {
                TextBox3.Text = nome;
                DropDownList3.SelectedValue = genero.ToString();
                TextBox4.Text = idade.ToString();
                Label2.Text = "";
            }
            else
            {
                Label8.Text = "Erro ao carregar formando.";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string id = TextBox5.Text;
            string nome = TextBox3.Text;
            char genero = char.Parse(DropDownList3.SelectedValue);
            string idade = TextBox4.Text;
            DBconnect db = new DBconnect();
            bool resultado = db.Update(id, nome, genero, idade);

            if (resultado)
            {
                Label8.Text = "Formando atualizado com sucesso.";
                TextBox3.Text = "";
                TextBox4.Text = "";
                DropDownList3.SelectedIndex = 0;
                TextBox5.Text = "";
            }
            else
            {
                Label8.Text = "Erro ao atualizar formando.";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedValue.Split('-')[0].Trim();

            DBconnect db = new DBconnect();
            bool resultado = db.Delete(id);

            if (resultado)
            {
                Label2.Text = "Formando excluído com sucesso.";
                TextBox3.Text = "";
                TextBox4.Text = "";
                DropDownList3.SelectedIndex = 0;
                DropDownList1.Items.Clear();
                db.CarregarFormandos(ref DropDownList1);
            }
            else
            {
                Label2.Text = "Erro ao excluir formando.";
            }
        }
    }
}





