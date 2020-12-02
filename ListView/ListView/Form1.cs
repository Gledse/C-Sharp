using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lstvltemListar = new ListViewItem();

            lstvltemListar.Text = txtCodigo.Text;
            lstvltemListar.SubItems.Add(txtNome.Text);
            lstvltemListar.SubItems.Add(txtContacto.Text);
            lstvltemListar.SubItems.Add(txtIdade.Text);

            lstvListar.Items.Add(lstvltemListar);

            txtCodigo.Text="";
            txtNome.Text="";
            txtContacto.Text="";
            txtIdade.Text="";
        }
    }
}
