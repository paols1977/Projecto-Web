using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalendario
{
    public partial class WebFormCalendario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            LblCalcularIdade.Text = "";

         

            if (!IsPostBack)
            {
                int i;
                for (i = 1; i <= 31; i++)
                {
                    DdlDia.Items.Add(i.ToString());
                }

                for (i = 1; i <= 12; i++)
                {
                    DdlMes.Items.Add(i.ToString());
                }
                for (i = DateTime.Today.Year; i >= 1900; i--)
                {
                    DdlAno.Items.Add(i.ToString());
                }

                DdlAno.Items.FindByText((DateTime.Today.Year - 18).ToString()).Selected = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //LblDataNascimento.Text = Calendar1.SelectedDate.ToString().Substring(0,10);
            LblDataNascimento.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void BtnCalcularIdade_Click(object sender, EventArgs e)
        {
            if (LblDataNascimento.Text == "")
            {
                LblCalcularIdade.Text = "Tem de indicar uma data!";
            }
            else
            {
                DateTime datanascimento = Calendar1.SelectedDate, today = DateTime.Today;
                int age = today.Year - datanascimento.Year;

                if (datanascimento > today.AddYears(-age))
                {
                    //Significa que ainda não fez anos
                    LblDiasAniversario.Text = "Ainda falta(m) " + (datanascimento.AddYears(age) - today).TotalDays.ToString() + " dia(s) para o aniversário!";
                    age--;
                }
                else
                {
                    //Significa que já fez anos
                    LblDiasAniversario.Text = "Ainda falta(m) " + (datanascimento.AddYears(age + 1) - today).TotalDays.ToString() + " dia(s) para o aniversário!";
                }

                LblCalcularIdade.Text = age.ToString() + " anos";
                //lblHoroscopo.Text = "signo: " + Horoscopo(datanascimento);
                lblHoroscopo.Text = "signo: " + Horoscopo(datanascimento.Month,datanascimento.Day, ref Image1);
                lblDiasVividas.Text = (today - datanascimento).TotalDays.ToString();





            }
        }

        protected void BtnCarregarData1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(TxtDataNascimento.Text);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                LblDataNascimento.Text = Calendar1.SelectedDate.ToShortDateString();
                LblDiasAniversario.Text = "";
            }
            catch
            {
                //TxtDataNascimento.Text = "Data incorreta!";
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + TxtDataNascimento.Text + "');", true);
        }

        protected void BtnCarregarData2_Click(object sender, EventArgs e)
        {
            string data = DdlDia.SelectedValue + "/" + DdlMes.SelectedValue + "/" + DdlAno.SelectedValue;
            try
            {
                DateTime dateTime = Convert.ToDateTime(data);
                Calendar1.TodaysDate = dateTime;
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                LblDataNascimento.Text = Calendar1.SelectedDate.ToShortDateString();
                TxtDataNascimento.Text = data;
                LblDiasAniversario.Text = "";
            }
            catch
            {
                TxtDataNascimento.Text = "Data incorreta!";
            }
        }


        string Horoscopo(DateTime data) {



            string signo = "";
            int mes, dia;
            mes = data.Month;
            dia = data.Day;

            if ((mes == 1 && dia >= 21) || (mes == 2 && dia <= 19))
            {
                signo = "Aquário";
                Image1.ImageUrl = "~/img/aquario.jpg";
                return signo;
            }
            if ((mes == 2 && dia >= 20) || (mes == 3 && dia <= 20))
            {
                signo = "Peixes";
                Image1.ImageUrl = "~/img/peixes.jpg";
                return signo;
            }
            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 20))
            {
                signo = "Carneiro";
                Image1.ImageUrl = "~/img/carneiro.jpg";
                return signo;
            }
            if ((mes == 4 && dia >= 21) || (mes == 5 && dia <= 20))
            {
                signo = "Touro";
                Image1.ImageUrl = "~/img/touro.jpg";
                return signo;
            }
            if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            {
                signo = "Gémeos";
                Image1.ImageUrl = "~/img/gemeos.jpg";
                return signo;
            }
            if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 21))
            {
                signo = "Caranguejo";
                Image1.ImageUrl = "~/img/caranguejo.jpg";
                return signo;
            }
            if ((mes == 7 && dia >= 22) || (mes == 8 && dia <= 22))
            {
                signo = "Leão";
                Image1.ImageUrl = "~/img/leao.jpg";
                return signo;
            }
            if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            {
                signo = "Virgem";
                Image1.ImageUrl = "~/img/virgem.jpg";
                return signo;
            }
            if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            {
                signo = "Balança";
                Image1.ImageUrl = "~/img/balanca.jpg";
                return signo;
            }
            if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            {
                signo = "Escorpião";
                Image1.ImageUrl = "~/img/escorpiao.jpg";
                return signo;
            }
            if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            {
                signo = "Sagitário";
                Image1.ImageUrl = "~/img/sagitario.jpg";
                return signo;
            }
            if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 20))
            {
                signo = "Capricórnio";
                Image1.ImageUrl = "~/img/capricornio.jpg";
                return signo;
            }

            return "";
        }


        string Horoscopo(int mes, int dia, ref Image imagemSigno)
        {


            if ((mes == 1 && dia >= 21) || (mes == 2 && dia <= 19))
            {

                imagemSigno.ImageUrl = "/img/aquario.jpg";
                return "Aquario";
            }


            if ((mes == 2 && dia >= 20) || (mes == 3 && dia <= 20))
            {
              
                imagemSigno.ImageUrl = "/img/peixes.jpg";
                return "Peixes";
            }


            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 20))
            {
               
                imagemSigno.ImageUrl = "/img/carneiro.jpg";
                return "Carneiro";
            }
            if ((mes == 4 && dia >= 21) || (mes == 5 && dia <= 20))
            {
                
                imagemSigno.ImageUrl = "/img/touro.jpg";
                return "Touro";
            }
            if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            {
                
                imagemSigno.ImageUrl = "/img/gemeos.jpg";
                return "Gémeos";
            }
            if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 21))
            {
               
                imagemSigno.ImageUrl = "/img/caranguejo.jpg";
                return "Caranguejo";
            }
            if ((mes == 7 && dia >= 22) || (mes == 8 && dia <= 22))
            {
              
                imagemSigno.ImageUrl = "/img/leao.jpg";
                return "Leão";
            }
            if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            {
               
                imagemSigno.ImageUrl = "/img/virgem.jpg";
                return "Virgem";
            }
            if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            {
               
                imagemSigno.ImageUrl = "/img/balanca.jpg";
                return "Balança";
            }
            if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            {
               
                imagemSigno.ImageUrl = "/img/escorpiao.jpg";
                return "Escorpião";
            }
            if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            {
                
                imagemSigno.ImageUrl = "/img/sagitario.jpg";
                return "Sagitário";
            }
            if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 20))
            {
              
                imagemSigno.ImageUrl = "/img/capricornio.jpg";
                return "Capricórnio";
            }







            return "";

        }

      }
    }



