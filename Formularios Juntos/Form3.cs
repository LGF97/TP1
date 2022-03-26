using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_Juntos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool pulsaTeclas(KeyPressEventArgs e)
        {
            return (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool duplicado = false;

            foreach (var item in lsBox.Items)
            {
                if (item.ToString().ToLower().Equals(txtNombre.Text.ToLower() + " " + txtApellido.Text.ToLower()))
                {
                    duplicado = true;
                }
            }
            if (!duplicado)
            {
                if (txtNombre.Text.Equals("") && txtApellido.Text.Equals(""))
                     MessageBox.Show("El Nombre y el Apellido estan vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (txtNombre.Text.Equals(""))
                    MessageBox.Show("El Nombre esta vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (txtApellido.Text.Equals(""))
                    MessageBox.Show("El Apellido esta vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    lsBox.Items.Add(txtNombre.Text + " " + txtApellido.Text);
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    ///Ordenamiento se podria hacer por la propiedad pero me olvide jaja
                    List<string> lsString = new List<string>();///Creamos una lista de Strings
              
                    foreach (var obj in lsBox.Items)///cargamos a la nueva lista la lista a ordenar
                        lsString.Add(obj.ToString());

                    lsBox.Items.Clear(); /// borramos la listbox porque ya la tenemos cargada en la nueva lista

                    lsString.Sort(); ///ordenamos
                    foreach (var obj in lsString) ///cargamos de la lista ordenada a la listbox
                        lsBox.Items.Add(obj.ToString());
                }

            }
            else
            {
                MessageBox.Show("Ya existe la persona a agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
        }





        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!pulsaTeclas(e))
                e.Handled = true;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (lsBox.SelectedItem != null)
                lsBox.Items.Remove(lsBox.SelectedItem);
            else
                MessageBox.Show("No hay nada seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!pulsaTeclas(e))
                e.Handled = true;
        }
    }
}
