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
    public partial class Pantalla_7 : Form
    {
        public Pantalla_7()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla_A regresarA = new Pantalla_A();
            regresarA.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Registro completado!");
        }

        private void Pantalla_7_Load(object sender, EventArgs e)
        {

        }
    }
}
