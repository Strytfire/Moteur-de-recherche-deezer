
namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmLecteurMultimedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLecteurMultimedia));
            this.btnChoisirFichier = new System.Windows.Forms.Button();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.diaMultimedia = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisirFichier
            // 
            this.btnChoisirFichier.Location = new System.Drawing.Point(276, 214);
            this.btnChoisirFichier.Name = "btnChoisirFichier";
            this.btnChoisirFichier.Size = new System.Drawing.Size(196, 35);
            this.btnChoisirFichier.TabIndex = 0;
            this.btnChoisirFichier.Text = "Choisir un fichier multimédia";
            this.btnChoisirFichier.UseVisualStyleBackColor = true;
            this.btnChoisirFichier.Click += new System.EventHandler(this.btnChoisirFichier_Click);
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(9, 9);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(463, 199);
            this.wmpLecteur.TabIndex = 1;
            // 
            // diaMultimedia
            // 
            this.diaMultimedia.FileName = "openFileDialog1";
            // 
            // FrmLecteurMultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.btnChoisirFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLecteurMultimedia";
            this.Text = "Lecteur Multimédia…";
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoisirFichier;
        public AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.OpenFileDialog diaMultimedia;
    }
}