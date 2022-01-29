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
        SqlConnection cn = new SqlConnection();
        DataSet ds = new DataSet();
        SqlCommandBuilder cb = new SqlCommandBuilder();
        bool isSaved = true;

        //objets pour les patients
        SqlCommand comP = new SqlCommand();
        SqlDataAdapter daP = new SqlDataAdapter();
        BindingSource bsP = new BindingSource();

        //object pour les consultations
        SqlCommand comC = new SqlCommand();
        SqlDataAdapter daC = new SqlDataAdapter();
        BindingSource bsC = new BindingSource();


        public FrmConsultation()
        {
            InitializeComponent();
        }

        private void FrmConsultation_Load(object sender, EventArgs e)
        {

            cn.ConnectionString = ConfigurationManager.ConnectionStrings["CabinetMedecinConnectionString"].ConnectionString;
            cn.Open();

            //gestion des patients
            comP.Connection = cn;
            comP.CommandText = "select * from patient";

            daP.SelectCommand = comP;
            
            daP.Fill(ds, "Patient");

            bsP.DataSource = ds;
            bsP.DataMember = "Patient";

            lstPatients.DisplayMember = "nom";
            lstPatients.ValueMember = "id";
            lstPatients.DataSource = bsP;


            //gestion des consultations
            comC.Connection = cn;
            comC.CommandText = "select * from consultation";
            daC.SelectCommand = comC;
            cb.DataAdapter = daC;
            daC.Fill(ds, "Consultation");

            //creation de la relation
            DataColumn colPK = ds.Tables["Patient"].Columns["id"];
            DataColumn colFK = ds.Tables["Consultation"].Columns["idPatient"];
            DataRelation relConsultationPatient = new DataRelation("fk_consultation_patient",colPK, colFK);
            ds.Relations.Add(relConsultationPatient);

            //lier le binding source consultation avec le binding source des patient
            bsC.DataSource = bsP;
            bsC.DataMember = "fk_consultation_patient";


            lstConsultations.DisplayMember = "dateConsultation";
            lstConsultations.ValueMember = "id";
            lstConsultations.DataSource = bsC;
            
            dtpDateConsultations.DataBindings.Add("Text", bsC, "dateConsultation");
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
            ds.Tables["patient"].Clear();
            daP.Fill(ds, "Patient");
        }
    }
}
