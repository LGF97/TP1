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
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_elem.Text =
              "Usted Selecciono los siguientes Elementos" + "\r\n" +
              "Sexo: " + (rbtn_masc.Checked ? rbtn_masc.Text : rbtn_fem.Text) + "\r\n" +
              "Estado Civil: " + (rbtn_Casado.Checked ? rbtn_Casado.Text : rbtn_Soltero.Text) + "\r\n" +
              "Oficio: " + "\r\n";
            if (chkdlb.CheckedItems.Count > 0)
                foreach (object itemChecked in chkdlb.CheckedItems)
                    lbl_elem.Text += "-" + itemChecked.ToString() + "\r\n";

            else
                lbl_elem.Text +="-Sin Oficio";

        }
    }
}
