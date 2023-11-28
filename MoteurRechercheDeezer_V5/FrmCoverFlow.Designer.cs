namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoverFlow));
            this.lblTitre = new System.Windows.Forms.Label();
            this.iC3DAlbums = new CDI.IndexCard3D.IC3D();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.panListeTitres = new System.Windows.Forms.Panel();
            this.txtTDL = new System.Windows.Forms.Label();
            this.lstTitres = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.panListeTitres.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(6, 298);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(33, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Titre";
            // 
            // iC3DAlbums
            // 
            this.iC3DAlbums.DisplayCards = 8;
            this.iC3DAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iC3DAlbums.Location = new System.Drawing.Point(0, -100);
            this.iC3DAlbums.Name = "iC3DAlbums";
            this.iC3DAlbums.Size = new System.Drawing.Size(598, 390);
            this.iC3DAlbums.TabIndex = 1;
            this.iC3DAlbums.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.iC3DAlbums_RenderText);
            this.iC3DAlbums.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.iC3DAlbums_IndexCardChanged);
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXsurY.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXsurY.Location = new System.Drawing.Point(524, 298);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(48, 13);
            this.lblXsurY.TabIndex = 2;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.MouseHover += new System.EventHandler(this.lblXsurY_MouseHover);
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(-1, 317);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(586, 45);
            this.wmpLecteur.TabIndex = 10;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            // 
            // panListeTitres
            // 
            this.panListeTitres.Controls.Add(this.txtTDL);
            this.panListeTitres.Controls.Add(this.lstTitres);
            this.panListeTitres.Location = new System.Drawing.Point(444, 0);
            this.panListeTitres.Name = "panListeTitres";
            this.panListeTitres.Size = new System.Drawing.Size(141, 290);
            this.panListeTitres.TabIndex = 12;
            this.panListeTitres.Visible = false;
            // 
            // txtTDL
            // 
            this.txtTDL.AutoSize = true;
            this.txtTDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDL.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTDL.Location = new System.Drawing.Point(3, 8);
            this.txtTDL.Name = "txtTDL";
            this.txtTDL.Size = new System.Drawing.Size(94, 13);
            this.txtTDL.TabIndex = 13;
            this.txtTDL.Text = "Titre de l\'album";
            // 
            // lstTitres
            // 
            this.lstTitres.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(4, 25);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(134, 251);
            this.lstTitres.TabIndex = 0;
            this.lstTitres.Click += new System.EventHandler(this.panList_Click);
            // 
            // FrmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.panListeTitres);
            this.Controls.Add(this.iC3DAlbums);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoverFlow";
            this.Text = "Zik\'nCo : Affichage \"Cover Flow\"";
            this.Load += new System.EventHandler(this.FrmCoverFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.panListeTitres.ResumeLayout(false);
            this.panListeTitres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private CDI.IndexCard3D.IC3D iC3DAlbums;
        private System.Windows.Forms.Label lblXsurY;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.Panel panListeTitres;
        private System.Windows.Forms.Label txtTDL;
        private System.Windows.Forms.ListBox lstTitres;
    }
}