using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_KeyPress(object sender,  KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string oracion = txtUser.Text;

            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> ListaPalabras = new List<string>(palabras);
            int conteo = 0;

            foreach(string palabra in ListaPalabras)
            {
                conteo++;
            }
            label1.Text = $"{conteo}";

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnContar.FlatAppearance.BorderColor = Color.Plum;
        }
    }
}
