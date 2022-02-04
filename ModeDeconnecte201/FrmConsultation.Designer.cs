
namespace ModeDeconnecte201
{
    partial class FrmConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lstConsultations = new System.Windows.Forms.ListBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDateConsultations = new System.Windows.Forms.DateTimePicker();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtDC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModeDeconnecte201.Properties.Resources.medical_record;
            this.pictureBox1.Location = new System.Drawing.Point(1053, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.ItemHeight = 25;
            this.lstPatients.Location = new System.Drawing.Point(28, 125);
            this.lstPatients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(275, 204);
            this.lstPatients.TabIndex = 3;
            // 
            // lstConsultations
            // 
            this.lstConsultations.FormattingEnabled = true;
            this.lstConsultations.ItemHeight = 25;
            this.lstConsultations.Location = new System.Drawing.Point(311, 125);
            this.lstConsultations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstConsultations.Name = "lstConsultations";
            this.lstConsultations.Size = new System.Drawing.Size(278, 204);
            this.lstConsultations.TabIndex = 4;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(215, 87);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(123, 30);
            this.btnRecherche.TabIndex = 12;
            this.btnRecherche.Text = "Chercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(28, 87);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(181, 30);
            this.txtRecherche.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDateConsultations
            // 
            this.dtpDateConsultations.Location = new System.Drawing.Point(605, 146);
            this.dtpDateConsultations.Name = "dtpDateConsultations";
            this.dtpDateConsultations.Size = new System.Drawing.Size(475, 30);
            this.dtpDateConsultations.TabIndex = 14;
            this.dtpDateConsultations.ValueChanged += new System.EventHandler(this.dtpDateConsultations_ValueChanged);
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(605, 182);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(475, 134);
            this.txtObservations.TabIndex = 15;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(628, 337);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(123, 30);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(707, 384);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(123, 30);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(649, 252);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(341, 30);
            this.txtDC.TabIndex = 18;
            this.txtDC.TextChanged += new System.EventHandler(this.txtDC_TextChanged);
            // 
            // FrmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 705);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dtpDateConsultations);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lstConsultations);
            this.Controls.Add(this.lstPatients);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConsultation";
            this.Text = "FrmConsultation";
            this.Load += new System.EventHandler(this.FrmConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.ListBox lstConsultations;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDateConsultations;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtDC;
    }
}