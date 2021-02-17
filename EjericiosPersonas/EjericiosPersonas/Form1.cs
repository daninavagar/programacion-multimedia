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
        // ATRIBUTO VARIAS PERSONAS
        Persona persona1, persona2, persona3;
        string p;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1EnviarPersona_Click(object sender, EventArgs e)
        {
            if (comboBox1Persona.SelectedIndex == 0)
            {
                if (persona1 == null)
                {
                    MessageBox.Show("VAYA, NO EXISTE LA PERSONA 1");
                } else
                {
                    labelMuestraPersona.Text = "La persona 1 tiene estos datos \n" + persona1.EscribirFormato(textBoxFormato.Text);
                }
                
            } else if (comboBox1Persona.SelectedIndex == 1)
            {
                if (persona2 == null)
                {
                    MessageBox.Show("VAYA, NO EXISTE LA PERSONA 2");
                } else 
                    labelMuestraPersona.Text = "La persona 2 tiene estos datos \n" + persona2.EscribirFormato(textBoxFormato.Text);
            }
            else if (comboBox1Persona.SelectedIndex == 2)
            {
                if (persona3 == null)
                {
                    MessageBox.Show("VAYA, NO EXISTE LA PERSONA 3");
                } else 
                    labelMuestraPersona.Text = "La persona 3 tiene estos datos \n" + persona3.EscribirFormato(textBoxFormato.Text);
            }
        }

        private void buttonEnviarDatos_Click(object sender, EventArgs e)
        {
            p = comboBox1Persona.Text;
            if (comboBox1Persona.SelectedIndex == 0)
            {
                MessageBox.Show("Has elegido la Primera persona");
                Fecha fechaNaci = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                persona1 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
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
                labelSALIDA.Text = p + "\n" + resultado;

            }
            else if (comboBox1Persona.SelectedIndex == 1)
            {
                MessageBox.Show("Has elegido la Segunda persona");
                Fecha fechaNaci2 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                Fecha fechaAdmi2 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                persona2 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci2, fechaAdmi2, Int32.Parse(textBoxTelefono.Text));
                string nombre2 = textBoxNombre.Text;
                string direccion2 = textBoxDireccion.Text;
                string dni2 = textBoxDNI.Text;
                int diaN2 = Int32.Parse(textBoxDiaN.Text);
                int mesN2 = Int32.Parse(textBoxMesN.Text);
                int anioN2 = Int32.Parse(textBoxAñoN.Text);
                int diaA2 = Int32.Parse(textBoxDiaA.Text);
                int mesA2 = Int32.Parse(textBoxMesA.Text);
                int anioA2 = Int32.Parse(textBoxAñoA.Text);
                int telefono2 = Int32.Parse(textBoxTelefono.Text);


                string resultado2 = persona2.EscribirFormato(textBoxFormato.Text);
                labelSALIDA.Text =  p + "\n" + resultado2;
            }
            else if (comboBox1Persona.SelectedIndex == 2)
            {
                MessageBox.Show("Has elegido la Tercera persona");
                Fecha fechaNaci3 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                Fecha fechaAdmi3 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                persona3 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci3, fechaAdmi3, Int32.Parse(textBoxTelefono.Text));
                string nombre3 = textBoxNombre.Text;
                string direccion3 = textBoxDireccion.Text;
                string dni3 = textBoxDNI.Text;
                int diaN3 = Int32.Parse(textBoxDiaN.Text);
                int mesN3 = Int32.Parse(textBoxMesN.Text);
                int anioN3 = Int32.Parse(textBoxAñoN.Text);
                int diaA3 = Int32.Parse(textBoxDiaA.Text);
                int mesA3 = Int32.Parse(textBoxMesA.Text);
                int anioA3 = Int32.Parse(textBoxAñoA.Text);
                int telefono3 = Int32.Parse(textBoxTelefono.Text);


                string resultado3 = persona3.EscribirFormato(textBoxFormato.Text);
                labelSALIDA.Text = p + "\n" + resultado3;
            }


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

        private void buttonJoven_Click(object sender, EventArgs e)
        {
            p = comboBox1Persona.Text;
            Fecha fechaNaci = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
            Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
            persona1 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
            Fecha fechaNaci2 = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
            Fecha fechaNaci3 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
            if (comboBox1Persona.SelectedIndex == 0)
            {
                if ((textBoxCambiarDia != null && !string.IsNullOrWhiteSpace(textBoxCambiarDia.Text)) &&
                 (textBoxCambiarMes != null && !string.IsNullOrWhiteSpace(textBoxCambiarMes.Text)) &&
                 (textBoxCambiarAño != null && !string.IsNullOrWhiteSpace(textBoxCambiarAño.Text))
                )
                {
                    
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

                   
                    

                }
                else
                {


                    fechaNaci = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                    fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
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

                    
                    
                }
            }
            else if (comboBox1Persona.SelectedIndex == 1)
            {
                if ((textBoxCambiarDia != null && !string.IsNullOrWhiteSpace(textBoxCambiarDia.Text)) &&
                 (textBoxCambiarMes != null && !string.IsNullOrWhiteSpace(textBoxCambiarMes.Text)) &&
                 (textBoxCambiarAño != null && !string.IsNullOrWhiteSpace(textBoxCambiarAño.Text))
                )
                {
                    
                    Fecha fechaAdmi2 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                    persona2 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci2, fechaAdmi2, Int32.Parse(textBoxTelefono.Text));
                    string nombre2 = textBoxNombre.Text;
                    string direccion2 = textBoxDireccion.Text;
                    string dni2 = textBoxDNI.Text;
                    int diaN2 = Int32.Parse(textBoxDiaN.Text);
                    int mesN2 = Int32.Parse(textBoxMesN.Text);
                    int anioN2 = Int32.Parse(textBoxAñoN.Text);
                    int diaA2 = Int32.Parse(textBoxDiaA.Text);
                    int mesA2 = Int32.Parse(textBoxMesA.Text);
                    int anioA2 = Int32.Parse(textBoxAñoA.Text);
                    int telefono2 = Int32.Parse(textBoxTelefono.Text);

                   
                    
                }
                else
                {


                    fechaNaci2 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                    Fecha fechaAdmi2 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                    Persona persona2 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci2, fechaAdmi2, Int32.Parse(textBoxTelefono.Text));
                    string cambiarNombre2 = persona1.CambiarNombre();
                    string direccion2 = textBoxDireccion.Text;
                    string cambiarDNI2 = persona1.CambiarDNI();
                    int diaN2 = Int32.Parse(textBoxDiaN.Text);
                    int mesN2 = Int32.Parse(textBoxMesN.Text);
                    int anioN2 = Int32.Parse(textBoxAñoN.Text);
                    int diaA2 = Int32.Parse(textBoxDiaA.Text);
                    int mesA2 = Int32.Parse(textBoxMesA.Text);
                    int anioA2 = Int32.Parse(textBoxAñoA.Text);
                    int telefono2 = Int32.Parse(textBoxTelefono.Text);

                    
                    
                }
            }
            else if (comboBox1Persona.SelectedIndex == 2)
            {
                fechaNaci3 = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
                Fecha fechaAdmi3 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                persona2 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci3, fechaAdmi3, Int32.Parse(textBoxTelefono.Text));
                string nombre2 = textBoxNombre.Text;
                string direccion2 = textBoxDireccion.Text;
                string dni2 = textBoxDNI.Text;
                int diaN3 = Int32.Parse(textBoxDiaN.Text);
                int mesN3 = Int32.Parse(textBoxMesN.Text);
                int anioN3 = Int32.Parse(textBoxAñoN.Text);
                int diaA3 = Int32.Parse(textBoxDiaA.Text);
                int mesA3 = Int32.Parse(textBoxMesA.Text);
                int anioA3 = Int32.Parse(textBoxAñoA.Text);
                int telefono3 = Int32.Parse(textBoxTelefono.Text);

                
            }
            else
            {


                fechaNaci3 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                Fecha fechaAdmi3 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                Persona persona3 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci3, fechaAdmi3, Int32.Parse(textBoxTelefono.Text));
                string cambiarNombre3 = persona1.CambiarNombre();
                string direccion3 = textBoxDireccion.Text;
                string cambiarDNI3 = persona1.CambiarDNI();
                int diaN3 = Int32.Parse(textBoxDiaN.Text);
                int mesN3 = Int32.Parse(textBoxMesN.Text);
                int anioN3 = Int32.Parse(textBoxAñoN.Text);
                int diaA3 = Int32.Parse(textBoxDiaA.Text);
                int mesA3 = Int32.Parse(textBoxMesA.Text);
                int anioA3 = Int32.Parse(textBoxAñoA.Text);
                int telefono3 = Int32.Parse(textBoxTelefono.Text);

                
                
            }

            if ( ( (fechaNaci.CambiarDia() < fechaNaci2.CambiarDia()) && (fechaNaci.CambiarDia() < fechaNaci3.CambiarDia())  ) && 
                 ( (fechaNaci.CambiarMes() < fechaNaci2.CambiarMes() ) && (fechaNaci.CambiarMes() < fechaNaci3.CambiarMes()) ) &&
                 ( (fechaNaci.CambiarAño() < fechaNaci2.CambiarAño()) && (fechaNaci.CambiarAño() < fechaNaci3.CambiarAño())) ) {

                labelJoven.Text = "La persona mas joven es " + persona3.EscribirFormato(textBoxFormato.Text);
            } else if ( (fechaNaci2.CambiarDia() < fechaNaci.CambiarDia()) && (fechaNaci2.CambiarDia() < fechaNaci3.CambiarDia()))
            {
                labelJoven.Text = "La persona mas joven es " + persona2.EscribirFormato(textBoxFormato.Text);
            }
            else if ((fechaNaci3.CambiarDia() < fechaNaci.CambiarDia()) && (fechaNaci3.CambiarDia() < fechaNaci2.CambiarDia()))
            {
                labelJoven.Text = "La persona mas joven es " + persona1.EscribirFormato(textBoxFormato.Text);
            }

        }































        private void buttonSumaDias_Click(object sender, EventArgs e)
        {
            p = comboBox1Persona.Text;
            if (comboBox1Persona.SelectedIndex == 0)
            {
                if ((textBoxCambiarDia != null && !string.IsNullOrWhiteSpace(textBoxCambiarDia.Text)) &&
                 (textBoxCambiarMes != null && !string.IsNullOrWhiteSpace(textBoxCambiarMes.Text)) &&
                 (textBoxCambiarAño != null && !string.IsNullOrWhiteSpace(textBoxCambiarAño.Text))
                )
                {
                    Fecha fechaNaci = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
                    Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                    persona1 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci, fechaAdmi, Int32.Parse(textBoxTelefono.Text));
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

                    fechaNaci.DiaSiguiente();
                    fechaNaci.DiaSiguiente();
                    string resultado = persona1.EscribirFormato(textBoxFormato.Text);
                    labelSALIDA.Text = p + "\n" + resultado;
                }
                else
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

                    fechaNaci.DiaSiguiente();
                    fechaNaci.DiaSiguiente();
                    string resultado = persona1.EscribirFormato(textBoxFormato.Text);
                    labelSALIDA.Text = resultado;
                }
            } else if (comboBox1Persona.SelectedIndex == 1)
            {
                if ((textBoxCambiarDia != null && !string.IsNullOrWhiteSpace(textBoxCambiarDia.Text)) &&
                 (textBoxCambiarMes != null && !string.IsNullOrWhiteSpace(textBoxCambiarMes.Text)) &&
                 (textBoxCambiarAño != null && !string.IsNullOrWhiteSpace(textBoxCambiarAño.Text))
                )
                {
                    Fecha fechaNaci2 = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
                    Fecha fechaAdmi2 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                    persona2 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci2, fechaAdmi2, Int32.Parse(textBoxTelefono.Text));
                    string nombre2 = textBoxNombre.Text;
                    string direccion2 = textBoxDireccion.Text;
                    string dni2 = textBoxDNI.Text;
                    int diaN2 = Int32.Parse(textBoxDiaN.Text);
                    int mesN2 = Int32.Parse(textBoxMesN.Text);
                    int anioN2 = Int32.Parse(textBoxAñoN.Text);
                    int diaA2 = Int32.Parse(textBoxDiaA.Text);
                    int mesA2 = Int32.Parse(textBoxMesA.Text);
                    int anioA2 = Int32.Parse(textBoxAñoA.Text);
                    int telefono2 = Int32.Parse(textBoxTelefono.Text);

                    fechaNaci2.DiaSiguiente();
                    fechaNaci2.DiaSiguiente();
                    string resultado2 = persona2.EscribirFormato(textBoxFormato.Text);
                    labelSALIDA.Text = p + "\n" + resultado2;
                }
                else
                {


                    Fecha fechaNaci2 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                    Fecha fechaAdmi2 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                    Persona persona2 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci2, fechaAdmi2, Int32.Parse(textBoxTelefono.Text));
                    string cambiarNombre2 = persona1.CambiarNombre();
                    string direccion2 = textBoxDireccion.Text;
                    string cambiarDNI2 = persona1.CambiarDNI();
                    int diaN2 = Int32.Parse(textBoxDiaN.Text);
                    int mesN2 = Int32.Parse(textBoxMesN.Text);
                    int anioN2 = Int32.Parse(textBoxAñoN.Text);
                    int diaA2 = Int32.Parse(textBoxDiaA.Text);
                    int mesA2 = Int32.Parse(textBoxMesA.Text);
                    int anioA2 = Int32.Parse(textBoxAñoA.Text);
                    int telefono2 = Int32.Parse(textBoxTelefono.Text);

                    fechaNaci2.DiaSiguiente();
                    fechaNaci2.DiaSiguiente();
                    string resultado2 = persona2.EscribirFormato(textBoxFormato.Text);
                    labelSALIDA.Text = resultado2;
                }
            } else if (comboBox1Persona.SelectedIndex == 2) {
                Fecha fechaNaci3 = new Fecha(Int32.Parse(textBoxCambiarDia.Text), Int32.Parse(textBoxCambiarMes.Text), Int32.Parse(textBoxCambiarAño.Text));
                Fecha fechaAdmi3 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                persona3 = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, fechaNaci3, fechaAdmi3, Int32.Parse(textBoxTelefono.Text));
                string nombre3 = textBoxNombre.Text;
                string direccion3 = textBoxDireccion.Text;
                string dni3 = textBoxDNI.Text;
                int diaN3 = Int32.Parse(textBoxDiaN.Text);
                int mesN3 = Int32.Parse(textBoxMesN.Text);
                int anioN3 = Int32.Parse(textBoxAñoN.Text);
                int diaA3 = Int32.Parse(textBoxDiaA.Text);
                int mesA3 = Int32.Parse(textBoxMesA.Text);
                int anioA3 = Int32.Parse(textBoxAñoA.Text);
                int telefono3 = Int32.Parse(textBoxTelefono.Text);

                fechaNaci3.DiaSiguiente();
                fechaNaci3.DiaSiguiente();
                string resultado3 = persona3.EscribirFormato(textBoxFormato.Text);
                labelSALIDA.Text = p + "\n" + resultado3;
            }
            else
            {


                Fecha fechaNaci3 = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAñoN.Text));
                Fecha fechaAdmi3 = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAñoA.Text));
                Persona persona3 = new Persona(textBoxCambiarNombre.Text, textBoxDireccion.Text, textBoxCambiarDNI.Text, fechaNaci3, fechaAdmi3, Int32.Parse(textBoxTelefono.Text));
                string cambiarNombre3 = persona1.CambiarNombre();
                string direccion3 = textBoxDireccion.Text;
                string cambiarDNI3 = persona1.CambiarDNI();
                int diaN3 = Int32.Parse(textBoxDiaN.Text);
                int mesN3 = Int32.Parse(textBoxMesN.Text);
                int anioN3 = Int32.Parse(textBoxAñoN.Text);
                int diaA3 = Int32.Parse(textBoxDiaA.Text);
                int mesA3 = Int32.Parse(textBoxMesA.Text);
                int anioA3 = Int32.Parse(textBoxAñoA.Text);
                int telefono3 = Int32.Parse(textBoxTelefono.Text);

                fechaNaci3.DiaSiguiente();
                fechaNaci3.DiaSiguiente();
                string resultado3 = persona3.EscribirFormato(textBoxFormato.Text);
                labelSALIDA.Text = resultado3;
            }
        
            
            

        }

        private void button1CambiarFecha_Click(object sender, EventArgs e)
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
            int cambiardiaA = fechaNaci.CambiarDia();
            int cambiarmesA = fechaNaci.CambiarMes();
            int cambiaranioA = fechaNaci.CambiarAño();
            int telefono = Int32.Parse(textBoxTelefono.Text);




            string resultado = persona1.EscribirFormato(textBoxFormato.Text);
            labelSALIDA.Text = resultado;
        }

        

        
    }
}
