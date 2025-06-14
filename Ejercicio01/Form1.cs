using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            listBoxTabla.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBoxTabla.Items.Add($" {int.Parse(txtUser.Text)} x {i} = {i * int.Parse(txtUser.Text) }");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
            btnTabla.Text = $"Tabla del '{txtUser.Text}'";

        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listBoxTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTabla_Enter(object sender, EventArgs e)
        {
            btnTabla.BackColor = Color.FromArgb(255, 24, 70, 90);
        }

        private void btnTabla_MouseHover(object sender, EventArgs e)
        {
           // btnTabla.BackColor = Color.FromArgb(30, 55, 55, 70);

        }
    }
}
