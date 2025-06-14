using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        private int tiempoRestante;
        private Timer temporizador;
        public Form1()
        {
            InitializeComponent();
            temporizador = new Timer();
            temporizador.Interval = 1000;
            temporizador.Tick += Temporizador_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tiempoRestante = (int)nMinutos.Value * 60 + (int)nSegundos.Value;
            if (tiempoRestante > 0)
            {
                temporizador.Start();
            }
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                labelTiempo.Text = $"{tiempoRestante / 60:D2}:{tiempoRestante % 60:D2}"; 
            }
            else
            {
                temporizador.Stop();
                MessageBox.Show("¡Se ha agotado el tiempo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
