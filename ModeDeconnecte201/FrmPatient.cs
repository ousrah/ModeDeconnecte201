using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModeDeconnecte201
{
    public partial class FrmPatient : Form
    {
        BindingSource bs;
        public FrmPatient()
        {
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            bs = db.remplirListe("patient");
            listBox1.DisplayMember = "nom";
            listBox1.ValueMember = "id";
            listBox1.DataSource = bs;
            dataGridView1.DataSource = bs;
        }
    }
}
