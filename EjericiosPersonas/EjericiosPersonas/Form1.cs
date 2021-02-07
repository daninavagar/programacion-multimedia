using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjericiosPersonas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviarDatos_Click(object sender, EventArgs e)
        {
            Fecha fechaNaci = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
            Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
            Persona persona1 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string dni = textBoxDNI.Text;
            int diaN = Int32.Parse(textBoxDiaN.Text);
            int mesN = Int32.Parse(textBoxMesN.Text);
            int anioN = Int32.Parse(textBoxAñoN.Text);
            int diaA = Int32.Parse(textBoxDiaA.Text);
            int mesA = Int32.Parse(textBoxMesA.Text);
            int anioA = Int32.Parse(textBoxAñoA.Text);
            int telefono = Int32.Parse(textBoxTelefono.Text);


            string resultado = persona1.EscribirFormato(textBoxFormato.Text);
            labelSALIDA.Text = resultado;
        }

        private void buttonCambiarNombreDNI_Click(object sender, EventArgs e)
        {
            Fecha fechaNaci = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
            Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
            Persona persona1 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
            string cambiarNombre = persona1.CambiarNombre();
            string direccion = textBoxDireccion.Text;
            string cambiarDNI = persona1.CambiarDNI();
            int diaN = Int32.Parse(textBoxDiaN.Text);
            int mesN = Int32.Parse(textBoxMesN.Text);
            int anioN = Int32.Parse(textBoxAñoN.Text);
            int diaA = Int32.Parse(textBoxDiaA.Text);
            int mesA = Int32.Parse(textBoxMesA.Text);
            int anioA = Int32.Parse(textBoxAñoA.Text);
            int telefono = Int32.Parse(textBoxTelefono.Text);
            
            


            string resultado = persona1.EscribirFormato(textBoxFormato.Text);
            labelSALIDA.Text = resultado;
        }

        private void buttonSumaDias_Click(object sender, EventArgs e)
        {
            Fecha fechaNaci = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
            Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
            Persona persona1 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
            string cambiarNombre = persona1.CambiarNombre();
            string direccion = textBoxDireccion.Text;
            string cambiarDNI = persona1.CambiarDNI();
            int diaN = Int32.Parse(textBoxDiaN.Text);
            int mesN = Int32.Parse(textBoxMesN.Text);
            int anioN = Int32.Parse(textBoxAñoN.Text);
            int diaA = Int32.Parse(textBoxDiaA.Text);
            int mesA = Int32.Parse(textBoxMesA.Text);
            int anioA = Int32.Parse(textBoxAñoA.Text);
            int telefono = Int32.Parse(textBoxTelefono.Text);

            fechaNaci.DiaSiguiente();
            fechaNaci.DiaSiguiente();
            string resultado = persona1.EscribirFormato(textBoxFormato.Text);
            labelSALIDA.Text = resultado;

        }

        private void button1CambiarFecha_Click(object sender, EventArgs e)
        {
            
            Fecha fechaNaci = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
            Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
            Persona persona1 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
            // persona1.CambiarNacimiento();
            string cambiarNombre = persona1.CambiarNombre();
            string direccion = textBoxDireccion.Text;
            string cambiarDNI = persona1.CambiarDNI();
            int diaN = Int32.Parse(textBoxDiaN.Text);
            int mesN = Int32.Parse(textBoxMesN.Text);
            int anioN = Int32.Parse(textBoxAñoN.Text);
            int cambiardiaA = fechaNaci.CambiarDia();
            int cambiarmesA = fechaNaci.CambiarMes();
            int cambiaranioA = fechaNaci.CambiarAño();
            int telefono = Int32.Parse(textBoxTelefono.Text);




            string resultado = persona1.EscribirFormato(textBoxFormato.Text);
            labelSALIDA.Text = resultado;
        }
    }
}
