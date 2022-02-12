using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Biblioteca_Publica_Virgilio_Barco
{
    public partial class Pantalla_14_Usuarios : Sistema_Biblioteca_Publica_Virgilio_Barco.Pantalla_U
    {
        public Pantalla_14_Usuarios()
        {
            InitializeComponent();
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

        private void Pantalla_14_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_A regresarA = new Pantalla_A();
            regresarA.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
