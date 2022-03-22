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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            txtInicio.Text = "Seleccione un ejercicio \r \n     para continuar...";
        }
        void CambiarColorBoton(int c)
        {
            if(c==1)
            {
                this.Ej2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
                this.Ej3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
                this.Ej1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));



       
            }
            else if(c==2)
            {
                this.Ej2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
                this.Ej1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
                this.Ej3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            }
            else
            {
                this.Ej3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
                this.Ej2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
                this.Ej1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            }
        }

            
        private void Ej1_Click(object sender, EventArgs e)
        {

            CambiarColorBoton(1);
            pn_forms.Controls.Clear();
            Form2 Frm = new Form2();
            Frm.TopLevel = false;///indicamos que es un objeto contenedor.
            pn_forms.Controls.Add(Frm);
            Frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("Quieres Salir?","confirmación", MessageBoxButtons.OKCancel);

            if (Result == DialogResult.OK) this.Dispose();
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(2);
            pn_forms.Controls.Clear();
            Form3 Frm = new Form3();
            Frm.TopLevel = false;///indicamos que es un objeto contenedor.
            pn_forms.Controls.Add(Frm);
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(3);
            pn_forms.Controls.Clear();
            Form4 Frm = new Form4();
            Frm.TopLevel = false;///indicamos que es un objeto contenedor.
            pn_forms.Controls.Add(Frm);
            Frm.Show();
        }
    }
}
