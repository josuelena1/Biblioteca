using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Biblioteca_Publica_Virgilio_Barco
{
    public partial class Pantalla_B_Usuario : Sistema_Biblioteca_Publica_Virgilio_Barco.Pantalla_B
    {
        public Pantalla_B_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pantalla_6_Usuarios irquiensomosE = new Pantalla_6_Usuarios();
            irquiensomosE.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pantalla_4_Usuarios ircatalogoU = new Pantalla_4_Usuarios();
            ircatalogoU.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_12_Usuarios irProgramas = new Pantalla_12_Usuarios();
            irProgramas.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla_1_Usuarios reservMesaU = new Pantalla_1_Usuarios();
            reservMesaU.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_10_Usuarios pedidosU = new Pantalla_10_Usuarios();
            pedidosU.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla_9_Usuarios prestamosU = new Pantalla_9_Usuarios();
            prestamosU.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla_8_Usuarios perfilU = new Pantalla_8_Usuarios();
            perfilU.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantalla_14_Usuarios historialU = new Pantalla_14_Usuarios();
            historialU.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
