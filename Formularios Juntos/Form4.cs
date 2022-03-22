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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        string GetSexo()
        {
            if (rbtn_masc.Checked == true)
                return "Masculino";
            else if (rbtn_fem.Checked == true)
                return "Femenino";
            return "";
        }
        string GetEstadoCivil()
        {
            if (rbtn_Casado.Checked == true)
                return "Casado";
            else if (rbtn_Soltero.Checked == true)
                return "Soltero";
            return "";
        }
        string GetOficio()
        {
            String oficios = "";
            if (chkdlb.CheckedItems.Count > 0)
                foreach (object itemChecked in chkdlb.CheckedItems)
                    oficios = oficios + "-" + itemChecked.ToString() + "\r\n";

            else
                oficios = "-Sin Oficio";

            return oficios;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_elem.Show();
            lbl_elem.Text =
    "Usted Selecciono los siguientes Elementos" + "\r\n" +
    "Sexo: " + GetSexo() + "\r\n" +
    "Estado Civil: " + GetEstadoCivil() + "\r\n" +
    "Oficio: " + "\r\n" + GetOficio();
        }

    }
}
