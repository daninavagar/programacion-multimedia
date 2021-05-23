using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_controlLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Insertar_Click(object sender, EventArgs e)
        {
            // Insertar en el label
            label_Resultado.Text = textBox_Nombre.Text + " " + textBox_Edad.Text + "\n";

            // Insertar en el listview

            ListViewItem item = new ListViewItem();

            item.Text = textBox_Nombre.Text; // 1º columna
            item.SubItems.Add(textBox_Edad.Text); // 2º columna

            listViewPersonas.Items.Add(item);

            //listViewPersonas.Items.Add(
                
            //    textBox_Nombre.Text + " " + textBox_Edad.Text);
        }

        private void listViewPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewPersonas.SelectedItems.Count != 0)
            {
                textBox_Nombre.Text = listViewPersonas.SelectedItems[0].SubItems[0].Text;
                textBox_Edad.Text = listViewPersonas.SelectedItems[0].SubItems[1].Text;
            }
            
            
            // listViewPersonas.SelectedItems;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

            if (listViewPersonas.SelectedItems.Count != 0)
            {
                // Borrar del ListView
                listViewPersonas.Items.Remove(listViewPersonas.SelectedItems[0]);


            }
        }

        private void buttonVaciar_Click(object sender, EventArgs e)
        {
            listViewPersonas.Items.Clear();
        }
    }
}
