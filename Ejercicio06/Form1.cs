using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var numero = int.Parse(maskUser.Text);

            //bool perfecto = true;
            int perfecto = 0;
            for (int i = 1; i < numero;  i++)
            {
                if (numero % i == 0)
                {
                    perfecto += i;
                }

            }
            if (perfecto == numero)
            {
                MessageBox.Show($"Hey! El número {numero} es perfecto.");
            }
            else
            {
                MessageBox.Show($"Ups! El número {numero} no es perfecto.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVerificar.FlatAppearance.BorderColor = Color.LightSteelBlue;
        }
    }
}
/*
 El número pefecto es aquel cuyos divisores, excluyendo el mismo número, suman el número.
1. variable perfecto, inicializada en 0
2. iteramos desde 1 hasta el penúltimo número del número ingresado.
3. validar si el número es divisible por alguno de los número dentro de su rango.
4. user = 6
5. 1, 2, 3, 4, 5
6. 6 / 1, 6/ 2, 6/ 3, 6/4, 6/5 si algunos de estos restos es 0
7. perfecto se le va a usar ese divisor
8. perfecto = 1 + 2 + 3 = 6

 */
