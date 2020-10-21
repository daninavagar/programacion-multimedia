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
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            var n2 = Convert.ToDouble(textBoxNumero2.Text);
            label1Resultado.Text += n1 + n2;


        }

        private void button1Resta_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            var n2 = Convert.ToDouble(textBoxNumero2.Text);
            label1Resultado.Text += n1 - n2;
        }

        private void button1Borrar_Click(object sender, EventArgs e)
        {
            label1Resultado.Text = "El resultado es: ";
            this.textBoxNumero2.Enabled = true;
        }

        private void button1Multiplicacion_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            var n2 = Convert.ToDouble(textBoxNumero2.Text);
            label1Resultado.Text += n1 * n2;
        }

        private void button1Division_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            var n2 = Convert.ToDouble(textBoxNumero2.Text);
                label1Resultado.Text += n1 / n2;
        }

        private void button1_POTENCIA_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            var n2 = Convert.ToDouble(textBoxNumero2.Text);
            label1Resultado.Text += Math.Pow(n1, n2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            this.textBoxNumero2.Enabled = false;
            label1Resultado.Text += string.Format("{0:F2}", Math.Pow(n1, 0.3333333333));
     
            
        }

        private void button1_RAIZ_CUADRADA_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            this.textBoxNumero2.Enabled = false;
            label1Resultado.Text += Math.Sqrt(n1);
        }

        private void button2_FACTORIAL_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToDouble(textBoxNumero1.Text);
            this.textBoxNumero2.Enabled = false;
            label1Resultado.Text += Fac(n1);

        }
        public static double Fac(double n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            else return n1 * Fac(n1 - 1);
        }
    }
}
