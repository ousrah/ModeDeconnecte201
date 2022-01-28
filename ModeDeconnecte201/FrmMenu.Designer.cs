
namespace ModeDeconnecte201
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMedecin = new System.Windows.Forms.ToolStripButton();
            this.btnPatient = new System.Windows.Forms.ToolStripButton();
            this.btnConsultation = new System.Windows.Forms.ToolStripButton();
            this.btnRendezVous = new System.Windows.Forms.ToolStripButton();
            this.btnFermer = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMedecin,
            this.btnPatient,
            this.btnConsultation,
            this.btnRendezVous,
            this.btnFermer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1296, 135);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMedecin
            // 
            this.btnMedecin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedecin.Image = global::ModeDeconnecte201.Properties.Resources.doctor;
            this.btnMedecin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(104, 132);
            this.btnMedecin.Text = "Medecin";
            this.btnMedecin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMedecin.Click += new System.EventHandler(this.btnMedecin_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Image = global::ModeDeconnecte201.Properties.Resources.examination;
            this.btnPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(104, 132);
            this.btnPatient.Text = "Patient";
            this.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnConsultation
            // 
            this.btnConsultation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultation.Image = global::ModeDeconnecte201.Properties.Resources.medical_record;
            this.btnConsultation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(136, 132);
            this.btnConsultation.Text = "Consultation";
            this.btnConsultation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConsultation.Click += new System.EventHandler(this.btnConsultation_Click);
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezVous.Image = global::ModeDeconnecte201.Properties.Resources.timetable;
            this.btnRendezVous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(138, 132);
            this.btnRendezVous.Text = "Rendez-Vous";
            this.btnRendezVous.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = global::ModeDeconnecte201.Properties.Resources.close;
            this.btnFermer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(104, 132);
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 656);
            this.panel1.TabIndex = 1;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 791);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPatient;
        private System.Windows.Forms.ToolStripButton btnConsultation;
        private System.Windows.Forms.ToolStripButton btnRendezVous;
        private System.Windows.Forms.ToolStripButton btnFermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnMedecin;
    }
}

