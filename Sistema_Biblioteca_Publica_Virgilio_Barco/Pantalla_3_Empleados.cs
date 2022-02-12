using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Biblioteca_Publica_Virgilio_Barco
{
    public partial class Pantalla_3_Empleados : Sistema_Biblioteca_Publica_Virgilio_Barco.Pantalla_E
    {
        public Pantalla_3_Empleados()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla_3_Empleados prestamoE = new Pantalla_3_Empleados();
            prestamoE.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla_14_Empleados historialE = new Pantalla_14_Empleados();
            historialE.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pantalla_8_Empleados perfil = new Pantalla_8_Empleados();
            perfil.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla_5_Empleados funcionesE = new Pantalla_5_Empleados();
            funcionesE.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_2_Empleados perfilE = new Pantalla_2_Empleados();
            perfilE.Show();
            this.Hide();
        }

        private void Pantalla_3_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_A regresarA = new Pantalla_A();
            regresarA.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
