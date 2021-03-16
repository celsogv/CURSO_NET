using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string valor = "sumar";
        int resultado;
        int numero1;
        int numero2;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            valor = "sumar";

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            valor = "restar";


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            numero1 = int.Parse(TextBox1.Text);
            numero2 = int.Parse(TextBox2.Text);
            resultado = numero1 + numero2;


            if (valor == "sumar")
            {
                resultado = numero1 + numero2;



            } else
            {
                resultado = numero1 - numero2;


            }


            Label3.Text = resultado.ToString();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}