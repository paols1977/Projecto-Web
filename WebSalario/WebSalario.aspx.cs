using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSalario
{
    public partial class WebSalario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
        }


        void Limpar()
        {

            Label1.Text = "";
            Label2.Text = "";
           
            TextBox2.Text = "";
            TextBox3.Text = "";

        }






        protected void Button1_Click(object sender, EventArgs e)
        {
            float salario = 0f, segSocial = 0f, liquido = 0f;

            if ((TextBox1.Text.Trim()).Length > 0)
            {
                try
                {
                    salario = float.Parse("0" + TextBox1.Text);
                    segSocial = salario * 0.2F;
                    TextBox2.Text = segSocial.ToString();

                    if (salario < 500)
                    {
                        Label1.Text = "";
                        Label2.Text = "";
                        liquido = salario - segSocial;

                    }
                    else if (salario >= 500 && salario < 1000)
                    {

                        Label1.Text = "12";
                        Label2.Text = (salario * 0.12F).ToString();
                        liquido = salario - segSocial - salario * 0.12F;
                    }
                    else if (salario >= 1000 && salario < 1500)
                    {

                        Label1.Text = "15";
                        Label2.Text = (salario * 0.15F).ToString();
                        liquido = salario - segSocial - salario * 0.15F;
                    }
                    else
                    {

                        Label1.Text = "18";
                        Label2.Text = (salario * 0.18F).ToString();
                        liquido = salario - segSocial - salario * 0.18F;
                    }
                    Label3.ForeColor = System.Drawing.Color.Green;
                    Label3.Text = (salario.ToString() + " - " + segSocial.ToString() + " - " + Label2.Text);
                    TextBox3.Text = liquido.ToString();


                }
                catch
                {
                    Limpar();
                    Label3.ForeColor = System.Drawing.Color.Red;
                    Label3.Text = "Erro";

                }

            }
              else
            {

                Limpar();
                Label3.ForeColor = System.Drawing.Color.RoyalBlue;
                Label3.Text = "Indique um valor";
            }

            }


        }
    }
