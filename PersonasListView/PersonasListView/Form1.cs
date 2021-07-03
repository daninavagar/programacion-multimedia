using System;
using System.Collections;
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
        ArrayList lista;
        int cont;
        public Form1()
        {
            InitializeComponent();
            lista = new ArrayList();
            cont = 0;
        }
        
        private void buttonAñadirPersona_Click(object sender, EventArgs e)
        {
            if (cont < 3)
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
                switch (cont)
                {
                    case 0:
                        lista.Add(persona);
                        break;
                    case 1:
                        lista.Add(persona);
                        break;
                    case 2:
                        lista.Add(persona);
                        break;
                }
                cont++;

                
               
            } else
            {
                MessageBox.Show("Solo puedes añadir 3 personas");
            }
            



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

                int posi = listViewPersonas.Items.IndexOf(listViewPersonas.SelectedItems[0]);
                listViewPersonas.Items.Remove(listViewPersonas.SelectedItems[0]);
                cont = cont - 1;
                label16.Text = "\n\n" + cont  + "\n";
                lista.RemoveAt(posi);
                


            }
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listViewPersonas.Items.Clear();
            listViewJoven.Items.Clear();
            listViewAntigua.Items.Clear();
            cont = 0;
            lista.Clear();
        }

        private void buttonCambiarDatos_Click(object sender, EventArgs e)
        {


            if (listViewPersonas.Items.Count != 0)
            {

                string DNICambiar = listViewPersonas.SelectedItems[0].SubItems[2].Text;
                string NombreCambiar = listViewPersonas.SelectedItems[0].SubItems[0].Text;
                Persona g = null;
                for (int i=0; i<lista.Count; i++)
                {
                    
                    g = (Persona)lista[i];
                    if (DNICambiar.Equals(g.DNI))
                    {
                        g.setDNI(textBoxCambiarDNI.Text);
                        g.setNombre(textBoxCambiarNombre.Text);
                    }
                }
                Actualizar();
            }
            

        }

        

        private void buttonSumaDias_Click(object sender, EventArgs e)
        {
            ArrayList aux = new ArrayList();
            

                aux.Add(lista[0]);
                lista[0] = lista[1];
                lista[1] = aux[0];
            
            Persona g = (Persona)lista[0];
            label17.Text += g.EscribirFormato("corto");


            /*
            if (listViewPersonas.Items.Count != 0)
            {
                Fecha fechaNaci = null;
                
                
                if (listViewPersonas.SelectedItems[0].Selected)
                {
                    fechaNaci = new Fecha(Int32.Parse(textBoxDiaN.Text), Int32.Parse(textBoxMesN.Text), Int32.Parse(textBoxAnioN.Text));
                    fechaNaci.DiaSiguiente();
                    fechaNaci.DiaSiguiente();
                    listViewPersonas.SelectedItems[0].SubItems[4].Text = fechaNaci.Escribir("corto");

                }
                Persona g = null;
                for (int i = 0; i < lista.Count; i++)
                {


                    g = (Persona)lista[i];
                    if (listViewPersonas.SelectedItems[0].SubItems[2].Text.Equals(g.DNI))
                    {
                        g.setFechaNaci(fechaNaci);
                    }
                }
            }

            */

        }
        

        private void buttonObtenerJoven_Click(object sender, EventArgs e)
        {

            if (listViewPersonas.Items.Count != 0)
            {
                int MenorDia = -1000000, MenorMes = -1000000, MenorAnio = -1000000;

                Actualizar();

                Persona p = null;

                foreach (Persona g in lista)
                {
                    if (((g.CambiarNacimiento().CambiarAnio() >= MenorAnio)) && ((g.CambiarNacimiento().CambiarMes() >= MenorMes)) &&
                         ((g.CambiarNacimiento().CambiarDia() >= MenorDia))
                        )
                    {
                        ListViewItem joven = new ListViewItem();
                        listViewJoven.Items.Clear();
                        joven.SubItems.Clear();
                        MenorDia = g.CambiarNacimiento().CambiarDia();
                        MenorMes = g.CambiarNacimiento().CambiarMes();
                        MenorAnio = g.CambiarNacimiento().CambiarAnio();
                        p = g;
                        joven.Text = p.Nombre;
                        joven.SubItems.Add(p.DNI);
                        joven.SubItems.Add(p.CambiarNacimiento().Escribir("corto"));
                        listViewJoven.Items.Add(joven);
                    }
                }
            }                        
            
        }

        private void buttonObtenerAntigua_Click(object sender, EventArgs e)
        {
            int MayorDia = 1000000, MayorMes = 1000000, MayorAnio = 1000000;

            Actualizar();

            Persona p = null;

            foreach (Persona g in lista)
            {
                if (((g.CambiarAdmision().CambiarAnio() <= MayorAnio)) && ((g.CambiarAdmision().CambiarMes() <= MayorMes)) &&
                     ((g.CambiarAdmision().CambiarDia() <= MayorDia))
                    )
                {
                    ListViewItem Antiguo = new ListViewItem();
                    listViewAntigua.Items.Clear();
                    Antiguo.SubItems.Clear();
                    MayorDia = g.CambiarAdmision().CambiarDia();
                    MayorMes = g.CambiarAdmision().CambiarMes();
                    MayorAnio = g.CambiarAdmision().CambiarAnio();
                    p = g;
                    Antiguo.Text = p.Nombre;
                    Antiguo.SubItems.Add(p.DNI);
                    Antiguo.SubItems.Add(p.CambiarAdmision().Escribir("corto"));
                    listViewAntigua.Items.Add(Antiguo);
                }
            }

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {            
            Persona p = null, g = null;
            listViewPersonas.Items.Clear();
            
            for (int i = 0; i < lista.Count; i++)
            {
                ListViewItem nuevo = new ListViewItem();
                g = (Persona)lista[i];

                p = new Persona(g.Nombre, g.Direccion, g.DNI, g.Telefono, 
                                g.CambiarNacimiento().CambiarDia(), g.CambiarNacimiento().CambiarMes(), g.CambiarNacimiento().CambiarAnio(),
                                g.CambiarAdmision().CambiarDia(), g.CambiarAdmision().CambiarMes(), g.CambiarAdmision().CambiarAnio()
                                );
                lista.RemoveAt(i);
                lista.Insert(i, p);

                nuevo.Text = g.Nombre;
                nuevo.SubItems.Add(g.Direccion);
                nuevo.SubItems.Add(g.DNI);
                nuevo.SubItems.Add(g.Telefono.ToString());
                nuevo.SubItems.Add(g.CambiarNacimiento().Escribir("corto"));
                nuevo.SubItems.Add(g.CambiarAdmision().Escribir("corto"));
                listViewPersonas.Items.Add(nuevo);
               
            }
            
        }
    }
}







    

