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
            db.creerTable("consultation");
            db.creerRelation("patient", "consultation", "id", "idPatient");
       
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("La suppression du patient entrainera la suppression de toutes ces consultations, voulez vous continuer?","Suppression",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DataRelation rel = db.ds.Relations["fk_consultation_patient"];
                rel.ChildKeyConstraint.DeleteRule = Rule.Cascade;
                bs.RemoveCurrent();
                db.MiseAjour("consultation");
                db.MiseAjour("patient");
                rel.ChildKeyConstraint.DeleteRule = Rule.None;

            }
        }
    }
}
