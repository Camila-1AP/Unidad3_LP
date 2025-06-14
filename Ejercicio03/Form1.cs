using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConvertir.FlatAppearance.BorderColor = Color.DimGray;
            


        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            char caracter = e.KeyChar;

            
            if (!char.IsDigit(caracter) && caracter != ',' && caracter != '.' && !char.IsControl(caracter))
            {
                e.Handled = true;
            }
            else if (caracter == ',' || caracter == '.')
            {
               
                if (txtUser.Text.Contains(",") || txtUser.Text.Contains("."))
                {
                    e.Handled = true;
                }
                
                else if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",")
                {
                    e.KeyChar = ',';
                }
                
                else if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".")
                {
                    e.KeyChar = '.';
                }
            }
        }

        private void Detalles(object sender, EventArgs e)
        {
           

            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double user = double.Parse(txtUser.Text);
            if (combo1.Text == "Metro" && combo2.Text == "Centimetro")
            {
                txtConversion.Text = $"{user * 100}";
                labelFormulaMuestra.Text = "Multiplica la longitud del valor por 100";

            }
            else if (combo1.Text == "Metro" && combo2.Text == "Pulgada")

            {
                txtConversion.Text = $"{user * 39.37}";
                labelFormulaMuestra.Text = "Multiplica la longitud del valor por 39.37";

            }
            else if (combo1.Text == "Metro" && combo2.Text == "Metro")
            {
                txtConversion.Text = $"{user}";
                labelFormulaMuestra.Text = " ";



            }
            else if (combo1.Text == "Centimetro" && combo2.Text == "Metro")
            {

                txtConversion.Text = $"{user / 100}";
                labelFormulaMuestra.Text = "Divide la longitud del valor por 100";


            }
            else if (combo1.Text == "Centimetro" && combo2.Text == "Pulgada")
            {
                txtConversion.Text = $"{user / 2.54}";
                labelFormulaMuestra.Text = "Divide la longitud del valor por 2.54";


            }
            else if (combo1.Text == "Centimetro" && combo2.Text == "Centimetro")
            {
                txtConversion.Text = $"{user}";
                labelFormulaMuestra.Text = " ";


            }
            else if (combo1.Text == "Pulgada" && combo2.Text == "Metro")
            {
                txtConversion.Text = $"{user / 39.27}";
                labelFormulaMuestra.Text = "Divide la longitud del valor por 39.27";


            }
            else if (combo1.Text == "Pulgada" && combo2.Text == "Pulgada")
            {
                txtConversion.Text = $"{user}";
                labelFormulaMuestra.Text = " ";


            }
            else if (combo1.Text == "Pulgada" && combo2.Text == "Pulgada")
            {
                txtConversion.Text = $"{user * 2.54}";
                labelFormulaMuestra.Text = "Multiplica la longitud del valor por 2.54";
            }
            else
            {
                MessageBox.Show("Hey! Seleccione unidades.");


            }
         
            label2.Text = $"{txtConversion.Text} {combo2.Text}";
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"{txtUser.Text} {combo1.Text} = ";
        }
    }
}
