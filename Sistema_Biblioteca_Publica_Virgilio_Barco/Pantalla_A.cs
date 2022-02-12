using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca_Publica_Virgilio_Barco
{
    public partial class Pantalla_A : Form
    {
        public Pantalla_A()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla_7 iralregistro = new Pantalla_7();
            this.Hide();
            iralregistro.Show();         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TEMPORAL YA QUE AÚN NO EXISTE BASE DE DATOS PARA EL LOGIN
            Pantalla_B_Usuario irusuario = new Pantalla_B_Usuario();
            irusuario.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TEMPORAL YA QUE AÚN NO EXISTE BASE DE DATOS PARA EL LOGIN
            Pantalla_B_Empleado irusuario = new Pantalla_B_Empleado();
            irusuario.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
