using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var original = txtUser.Text.ToLower();

            string invertida = new string(original.Reverse().ToArray());

            if (original == invertida)
            {
                MessageBox.Show("✅ La palabra ingresada es palíndroma!");
            }
            else
            {
                MessageBox.Show("⛔ La palabra ingresada no es palíndroma.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
