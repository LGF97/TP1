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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool Duplicado(ListBox lista)
        {
            foreach (var item in lista.Items)
                if (item.ToString().ToLower().Equals(txtNombre.Text.ToLower()))
                    return true;
            return false;
        }
        void AgregarPersona()
        {
            if (!(Duplicado(ls_agregados) || Duplicado(ls_pasados)))
                if (txtNombre.Text.Equals(""))
                    MessageBox.Show("El Nombre esta Vacío","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ls_agregados.Items.Add(txtNombre.Text);
            else
                MessageBox.Show("El Nombre ya Existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNombre.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPersona();
        }

        private void btn_pasar_Click(object sender, EventArgs e)
        {
            if (ls_agregados.SelectedItem != null)
            {
                ls_pasados.Items.Add(ls_agregados.SelectedItem.ToString());
                ls_agregados.Items.Remove(ls_agregados.SelectedItem);
            }
            else
                MessageBox.Show("No hay nada seleccionado", "Error");

        }

        private void btn_agregarAll_Click(object sender, EventArgs e)
        {
            if (ls_agregados.Items.Count > 0)
            {
                ls_pasados.Items.AddRange(ls_agregados.Items);
                ls_agregados.Items.Clear(); /// Borro los items de la listbox izquierda
            }
            else

                MessageBox.Show("No hay items", "Atención!");
        }
        private void Btn_agregar(object sender, EventArgs e)
        {
            AgregarPersona();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8))
                e.Handled = true;
               
        }
    }
}
