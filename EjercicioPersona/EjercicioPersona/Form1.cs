using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1EnviarDatos_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = textBoxNombre.Text;
            persona.direccion = textBox1Direccion.Text;
            persona.DNI = textBoxDNI.Text;
            persona.diaNaci = Int32.Parse(textBoxDiaNaci.Text);
            persona.mesNaci = Int32.Parse(textBoxMesNaci.Text);
            persona.anioNaci = Int32.Parse(textBoxAñoNaci.Text);
            persona.diaAdmi = Int32.Parse(textBoxDiaAdmi.Text);
            persona.mesAdmi = Int32.Parse(textBoxMesAdmi.Text);
            persona.anioAdmi = Int32.Parse(textBoxAñoAdmi.Text);
            persona.telefono = Int32.Parse(textBoxTelefono.Text);
            labelSALIDA.Text = "SALIDA \nEl nombre de la persona es: " + persona.nombre
                                + "\nsu direccion es " + persona.direccion
                                + "\nsu DNI es " + persona.DNI
                                + "\nsu fecha de nacimiento es " + persona.diaNaci + "-" + persona.mesNaci + "-" + persona.anioNaci
                                + "\nsu fecha de admision es " + persona.diaAdmi + "-" + persona.mesAdmi + "-" + persona.anioAdmi
                                + "\ny su telefono es " + persona.telefono;
        }

        private void buttonCambiarDNI_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = persona.CambiarNombre(textBoxCambiarNombre.Text);
            persona.DNI = persona.CambiarDNI(textBox1CambiarDNI.Text);
            labelSALIDA.Text = "\nEl nuevo nombre de la persona es: " + persona.nombre
                                + "\nsu direccion es " + persona.direccion
                                + "\nsu nuevo DNI es " + persona.DNI
                                + "\nsu fecha de nacimiento es " + persona.diaNaci + "-" + persona.mesNaci + "-" + persona.anioNaci
                                + "\nsu fecha de admision es " + persona.diaAdmi + "-" + persona.mesAdmi + "-" + persona.anioAdmi
                                + "\ny su telefono es " + persona.telefono;
        }

        private void buttonSumaDias_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.diaNaci = Int32.Parse(textBoxDiaNaci.Text);
            persona.mesNaci = Int32.Parse(textBoxMesNaci.Text);
            persona.anioNaci = Int32.Parse(textBoxAñoNaci.Text);
            persona.diaNaci++;
            persona.diaNaci++;
            if (persona.diaNaci >= 32 && (persona.mesNaci == 1 || persona.mesNaci == 3 || persona.mesNaci == 5 || persona.mesNaci == 7 || persona.mesNaci == 8 || persona.mesNaci == 10))
            {
                persona.diaNaci = 1;
                persona.mesNaci++;
            }
            else if (persona.diaNaci >= 31 && (persona.mesNaci == 2 || persona.mesNaci == 4 || persona.mesNaci == 6 || persona.mesNaci == 9 || persona.mesNaci == 11))
            {
                persona.diaNaci = 1;
                persona.mesNaci++;
            }
            else if (persona.diaNaci == 32 && persona.mesNaci == 12)
            {
                persona.diaNaci = 1;
                persona.mesNaci = 1;
                persona.anioNaci++;
            }
            label1Sumarfecha.Text = "\n" + persona.diaNaci + "-" + persona.mesNaci + "-" + persona.anioNaci;
            
    }
    }
}
