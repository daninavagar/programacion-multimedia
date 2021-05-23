using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonasListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAñadirPersona_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            Persona persona = new Persona(textBoxNombre.Text, textBoxDireccion.Text, textBoxDNI.Text, Int32.Parse(textBoxTelefono.Text),
                Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAnioN.Text),
                Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAnioA.Text));


            Fecha fechaNaci = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAnioN.Text));
            Fecha fechaAdmi = new Fecha(Int32.Parse(textBoxDiaA.Text), Int32.Parse(textBoxMesA.Text), Int32.Parse(textBoxAnioA.Text));
            item.Text = textBoxNombre.Text;
            item.SubItems.Add(textBoxDireccion.Text);
            item.SubItems.Add(textBoxDNI.Text);
            item.SubItems.Add(textBoxTelefono.Text);
            string formato = "corto";
            item.SubItems.Add(fechaNaci.Escribir(formato));
            item.SubItems.Add(fechaAdmi.Escribir(formato));
            listViewPersonas.Items.Add(item);

            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxDNI.Text = "";
            textBoxTelefono.Text = "";
            textBoxDiaN.Text = "";
            textBoxMesN.Text = "";
            textBoxAnioN.Text = "";
            textBoxDiaA.Text = "";
            textBoxMesA.Text = "";
            textBoxAnioA.Text = "";



        }

        private void listViewPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPersonas.SelectedItems.Count != 0)
            {
                textBoxNombre.Text = listViewPersonas.SelectedItems[0].SubItems[0].Text;
                textBoxDireccion.Text = listViewPersonas.SelectedItems[0].SubItems[1].Text;
                textBoxDNI.Text = listViewPersonas.SelectedItems[0].SubItems[2].Text;
                textBoxTelefono.Text = listViewPersonas.SelectedItems[0].SubItems[3].Text;
                string aux = listViewPersonas.SelectedItems[0].SubItems[4].Text;
                string[] linea = aux.Split('-');
                textBoxDiaN.Text = linea[0];
                textBoxMesN.Text = linea[1];
                textBoxAnioN.Text = linea[2];
                aux = listViewPersonas.SelectedItems[0].SubItems[5].Text;
                string[] linea2 = aux.Split('-');
                textBoxDiaA.Text = linea2[0];
                textBoxMesA.Text = linea2[1];
                textBoxAnioA.Text = linea2[2];

            }
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listViewPersonas.SelectedItems.Count != 0)
            {

                listViewPersonas.Items.Remove(listViewPersonas.SelectedItems[0]);


            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listViewPersonas.Items.Clear();
        }

        private void buttonCambiarDatos_Click(object sender, EventArgs e)
        {

            if (listViewPersonas.SelectedItems[0].Selected)
            {

                string nuevoNombre = textBoxCambiarNombre.Text;
                string nuevoDNI = textBoxCambiarDNI.Text;
                listViewPersonas.SelectedItems[0].SubItems[0].Text = nuevoNombre;
                listViewPersonas.SelectedItems[0].SubItems[2].Text = nuevoDNI;
            }
            




        }
    }
}







    

