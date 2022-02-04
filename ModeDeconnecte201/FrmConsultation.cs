using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ModeDeconnecte201
{
    public partial class FrmConsultation : Form
    {

        BindingSource bsP;


        BindingSource bsC;


        public FrmConsultation()
        {
            InitializeComponent();
        }

        private void FrmConsultation_Load(object sender, EventArgs e)
        {

            bsP = db.remplirListe("patient");

            lstPatients.DisplayMember = "nom";
            lstPatients.ValueMember = "id";
            lstPatients.DataSource = bsP;




            bsC = db.remplirListeRelation("consultation", bsP, "id", "idPatient");



            lstConsultations.DisplayMember = "dateConsultation";
            lstConsultations.ValueMember = "id";
            lstConsultations.DataSource = bsC;

            txtDC.DataBindings.Add("Text", bsC, "dateConsultation");
            txtObservations.DataBindings.Add("Text", bsC, "observation");


        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            bsP.Filter = "nom like '%" + txtRecherche.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPatient f = new FrmPatient();
            f.ShowDialog();
            //   ds.Tables["patient"].Clear();
            //   daP.Fill(ds, "Patient");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bsC.AddNew();
            txtDC.Text = DateTime.Now.ToString();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bsC.EndEdit();
            //  daC.Update(ds.Tables["Consultation"]);
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDateConsultations.Value = Convert.ToDateTime(txtDC.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void dtpDateConsultations_ValueChanged(object sender, EventArgs e)
        {
            txtDC.Text = dtpDateConsultations.Value.ToString();
        }
    }
}
