using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04___Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            Circulo c1 = new Circulo();
            double resultado = c1.Area();
            label1Resultado.Text += resultado;
        }
    }
}
