using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
            int numero = int.Parse(maskUser.Text);

            bool primo = true;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
            {
                MessageBox.Show($"Hey! El número {numero} es primo.");
            }
            else
            {
                MessageBox.Show($"Ups! El número {numero} no es primo.");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVerificar.FlatAppearance.BorderColor = Color.MediumSlateBlue;
        }
    }
}



/*
 Un primo es aquel que es mayor que uno y solo es divisible por 1 y por si mismo.

1. Variable bool true.
2. user = 5
3. 2, 3, 4
4. 5 % 2, 5 % 3, 5 % 4 == 0
5. false
 */
