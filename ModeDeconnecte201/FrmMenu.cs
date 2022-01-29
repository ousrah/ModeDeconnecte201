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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnMedecin_Click(object sender, EventArgs e)
        {
            FrmMedecin f = new FrmMedecin();
            AfficherFenetre(f);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfficherFenetre(Form f)
        {
            if (panel1.Controls.Count > 0)
            {
                Form oldForm = (Form)panel1.Controls[0];
                oldForm.Close();
            }

            panel1.Controls.Clear();
           f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            FrmPatient f = new FrmPatient();
            AfficherFenetre(f);
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            //permet d'afficher la fenetre de la consultation
            AfficherFenetre(new FrmConsultation());
        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            AfficherFenetre(new FrmRendezVous());

        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (panel1.Controls.Count > 0)
            {
                Form oldForm = (Form)panel1.Controls[0];
                oldForm.Close();
            }

        }
    }
}
