using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ModeDeconnecte201
{
    public partial class FrmMedecin : Form
    {

        private string cs = @"data source=.\sqlexpress2008;initial catalog=cabinetMedecin;user id=sa;Password=P@ssw0rd";
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource bs = new BindingSource();

        public FrmMedecin()
        {
            InitializeComponent();
        }

        private void FrmMedecin_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = cs;
            cn.Open();
            com.Connection = cn;
            com.CommandText = "select * from medecin";

            da.SelectCommand = com;
            da.Fill(ds, "Medecin");

            bs.DataSource = ds;
            bs.DataMember = "Medecin";

            lstMedecin.DisplayMember = "nom";
            lstMedecin.ValueMember = "id";
            lstMedecin.DataSource = bs;

        /*    comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = bs;*/

         //   dataGridView1.DataSource = bs;

            txtNom.DataBindings.Add("Text", bs, "nom");
            txtPrenom.DataBindings.Add("Text", bs, "prenom");
            txtTelephone.DataBindings.Add("Text", bs, "telephone");
            txtEmail.DataBindings.Add("Text", bs, "email");


        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            bs.Filter = "nom like '%" + txtRecherche.Text + "%'";
        }
    }
}
