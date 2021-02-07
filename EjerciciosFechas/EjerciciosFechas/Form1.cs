using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosFechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1SALIDA_Click(object sender, EventArgs e)
        {
            Fecha fecha = new Fecha(Int32.Parse(textBoxDia.Text), Int32.Parse(textBoxMes.Text), Int32.Parse(textBoxAño.Text));
            int dia = fecha.CambiarDia();
            int mes = fecha.CambiarMes();
            int año = fecha.CambiarAño();
            string formato = fecha.Escribir(textBoxFormato.Text);
            labelSALIDA.Text = formato;
        }

        private void buttonBisiesto_Click(object sender, EventArgs e)
        {
            Fecha fecha = new Fecha(Int32.Parse(textBoxDia.Text), Int32.Parse(textBoxMes.Text), Int32.Parse(textBoxAño.Text));
            int dia = fecha.CambiarDia();
            int mes = fecha.CambiarMes();
            int año = fecha.CambiarAño();

            if (fecha.EsBisiesto())
            {
                MessageBox.Show("EL AÑO ES BISIESTO");
            }
            else
            {
                MessageBox.Show("EL AÑO NO ES BISIESTO");
            }
        }

        private void buttonDiaSumar_Click(object sender, EventArgs e)
        {
            Fecha fecha = new Fecha(Int32.Parse(textBoxDia.Text), Int32.Parse(textBoxMes.Text), Int32.Parse(textBoxAño.Text));
            int dia = fecha.CambiarDia();
            int mes = fecha.CambiarMes();
            int año = fecha.CambiarAño();

            fecha.DiaSiguiente();
            string formato = fecha.Escribir(textBoxFormato.Text);
            labelSALIDA.Text = formato;
        }
    }
}
