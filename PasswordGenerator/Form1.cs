using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private Generador generador = new Generador();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                String contrasenya = generador.generarcontrasenya();
                textBox1.Text = contrasenya;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool prueba = int.TryParse(textBox2.Text, out int result);
            if(prueba)
            {
                generador.setNumCaracteres(int.Parse(textBox2.Text));
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EASTER EGG :)");
        }
    }
}
