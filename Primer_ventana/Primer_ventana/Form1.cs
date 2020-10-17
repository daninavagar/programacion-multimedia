using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Suma_Click(object sender, EventArgs e)
        { 
            var n1 = Convert.ToInt32(textBoxNumero1.Text);
            var n2 = Convert.ToInt32(textBoxNumero2.Text);
            label1Resultado.Text += n1 + n2;


        }

        private void button1Resta_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToInt32(textBoxNumero1.Text);
            var n2 = Convert.ToInt32(textBoxNumero2.Text);
            label1Resultado.Text += n1 - n2;
        }

        private void button1Borrar_Click(object sender, EventArgs e)
        {
            label1Resultado.Text = "El resultado es: ";
        }

        private void button1Multiplicacion_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToInt32(textBoxNumero1.Text);
            var n2 = Convert.ToInt32(textBoxNumero2.Text);
            label1Resultado.Text += n1 * n2;
        }

        private void button1Division_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToInt32(textBoxNumero1.Text);
            var n2 = Convert.ToInt32(textBoxNumero2.Text);
                label1Resultado.Text += n1 / n2;
        }
    }
}
