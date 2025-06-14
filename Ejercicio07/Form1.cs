using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
       
        private void btnPrimos_Click(object sender, EventArgs e)
        {
            var inicio = int.Parse(txt1.Text);
            var final = int.Parse(txt2.Text);

            
           


            for (int i = inicio; i <= final; i++)
            {
                if (i < 2) continue;
                bool primo = true;
              

                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }        
                    
                }
                if (primo)
                {
                    listBoxPrimos.Items.Add(i);
                }
            }
        }
    }
}
