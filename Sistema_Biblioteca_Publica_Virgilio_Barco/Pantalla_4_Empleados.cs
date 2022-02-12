using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Biblioteca_Publica_Virgilio_Barco
{
    public partial class Pantalla_4_Empleados : Sistema_Biblioteca_Publica_Virgilio_Barco.Pantalla_E
    {
        public Pantalla_4_Empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_A regresarA = new Pantalla_A();
            regresarA.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pantalla_6_Empleados irquiensomosE = new Pantalla_6_Empleados();
            irquiensomosE.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Pantalla_4_Empleados ircatalogoE = new Pantalla_4_Empleados();
            ircatalogoE.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantalla_13_Empleados irInscripProgra = new Pantalla_13_Empleados();
            irInscripProgra.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla_1_Empleados reservPuestos = new Pantalla_1_Empleados();
            reservPuestos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla_11_Empleados verpedidosE = new Pantalla_11_Empleados();
            verpedidosE.Show();
            this.Hide();
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

        private void Pantalla_4_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
