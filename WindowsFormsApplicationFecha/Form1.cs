using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationFecha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Boton1_Click(object sender, EventArgs e)
        {

            Fecha clase = new Fecha(); 
            clase.dia = clase.CambiarDia(Int32.Parse(textBox1Dia.Text));
            clase.mes = clase.CambiarMes(Int32.Parse(textBoxMes.Text));
            clase.anio = clase.CambiarAño(Int32.Parse(textBoxAño.Text));
            labelSALIDA.Text = "La Fecha es : " + clase.dia + "/" + clase.mes + "/" + clase.anio;

        }

        private void button1DIA_Click(object sender, EventArgs e)
        {
            Fecha clase = new Fecha();
            clase.dia = clase.CambiarDia(Int32.Parse(textBoxCambiarDia.Text));
            clase.mes = clase.CambiarMes(Int32.Parse(textBoxMes.Text));
            clase.anio = clase.CambiarAño(Int32.Parse(textBoxAño.Text));
            labelSALIDA.Text = "La Fecha es : " + clase.dia + "/" + clase.mes + "/" + clase.anio;
            
        }

        private void buttonMES_Click(object sender, EventArgs e)
        {
            Fecha clase = new Fecha();
            clase.dia = clase.CambiarDia(Int32.Parse(textBoxCambiarDia.Text));
            clase.mes = clase.CambiarMes(Int32.Parse(textBoxCambiarMes.Text));
            clase.anio = clase.CambiarAño(Int32.Parse(textBoxAño.Text));
            labelSALIDA.Text = "La Fecha es : " + clase.dia + "/" + clase.mes + "/" + clase.anio;
        }

        private void buttonAÑO_Click(object sender, EventArgs e)
        {
            Fecha clase = new Fecha();
            clase.dia = clase.CambiarDia(Int32.Parse(textBoxCambiarDia.Text));
            clase.mes = clase.CambiarMes(Int32.Parse(textBoxCambiarMes.Text));
            clase.anio = clase.CambiarAño(Int32.Parse(textBox2CambiarAño.Text));
            labelSALIDA.Text = "La Fecha es : " + clase.dia + "/" + clase.mes + "/" + clase.anio;
        }

        private void button1DiaSiguiente_Click(object sender, EventArgs e)
        {
            Fecha clase = new Fecha();
            clase.dia = clase.CambiarDia(Int32.Parse(textBoxCambiarDia.Text));
            clase.mes = clase.CambiarMes(Int32.Parse(textBoxCambiarMes.Text));
            clase.anio = clase.CambiarAño(Int32.Parse(textBox2CambiarAño.Text));
            clase.DiaSiguiente();
            labelSALIDA.Text = "La Fecha es : " + clase.dia + "/" + clase.mes + "/" + clase.anio;
        }
    }
}
