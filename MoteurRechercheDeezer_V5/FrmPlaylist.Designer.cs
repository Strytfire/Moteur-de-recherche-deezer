namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaylist));
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.btnTousLesExtraits = new System.Windows.Forms.Button();
            this.btnVersDroiteUn = new System.Windows.Forms.Button();
            this.btnVersDroiteTous = new System.Windows.Forms.Button();
            this.btnVersGaucheUn = new System.Windows.Forms.Button();
            this.btnVersGaucheTous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(12, 40);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(263, 264);
            this.lstGauche.TabIndex = 0;
            this.lstGauche.SelectedIndexChanged += new System.EventHandler(this.lstGauche_SelectedIndexChanged);
            // 
            // lstDroite
            // 
            this.lstDroite.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(409, 40);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(237, 186);
            this.lstDroite.TabIndex = 1;
            this.lstDroite.SelectedIndexChanged += new System.EventHandler(this.lstDroite_SelectedIndexChanged);
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPlaylist.Location = new System.Drawing.Point(409, 21);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(136, 13);
            this.lblPlaylist.TabIndex = 2;
            this.lblPlaylist.Text = "Morceaux choisis (Playlist) :";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.Black;
            this.lblAlbum.Location = new System.Drawing.Point(12, 20);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(105, 13);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "Morceau de l\'album :";
            // 
            // btnTousLesExtraits
            // 
            this.btnTousLesExtraits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTousLesExtraits.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTousLesExtraits.Location = new System.Drawing.Point(412, 241);
            this.btnTousLesExtraits.Name = "btnTousLesExtraits";
            this.btnTousLesExtraits.Size = new System.Drawing.Size(234, 48);
            this.btnTousLesExtraits.TabIndex = 4;
            this.btnTousLesExtraits.Text = "Jouer les extraits...";
            this.btnTousLesExtraits.UseVisualStyleBackColor = true;
            this.btnTousLesExtraits.Click += new System.EventHandler(this.btnTousLesExtraits_Click);
            // 
            // btnVersDroiteUn
            // 
            this.btnVersDroiteUn.BackColor = System.Drawing.Color.Transparent;
            this.btnVersDroiteUn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVersDroiteUn.Location = new System.Drawing.Point(281, 40);
            this.btnVersDroiteUn.Name = "btnVersDroiteUn";
            this.btnVersDroiteUn.Size = new System.Drawing.Size(122, 33);
            this.btnVersDroiteUn.TabIndex = 5;
            this.btnVersDroiteUn.Text = "> Un";
            this.btnVersDroiteUn.UseVisualStyleBackColor = false;
            // 
            // btnVersDroiteTous
            // 
            this.btnVersDroiteTous.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVersDroiteTous.Location = new System.Drawing.Point(281, 79);
            this.btnVersDroiteTous.Name = "btnVersDroiteTous";
            this.btnVersDroiteTous.Size = new System.Drawing.Size(122, 33);
            this.btnVersDroiteTous.TabIndex = 6;
            this.btnVersDroiteTous.Text = ">> Tous";
            this.btnVersDroiteTous.UseVisualStyleBackColor = true;
            // 
            // btnVersGaucheUn
            // 
            this.btnVersGaucheUn.ForeColor = System.Drawing.Color.Black;
            this.btnVersGaucheUn.Location = new System.Drawing.Point(281, 154);
            this.btnVersGaucheUn.Name = "btnVersGaucheUn";
            this.btnVersGaucheUn.Size = new System.Drawing.Size(122, 33);
            this.btnVersGaucheUn.TabIndex = 7;
            this.btnVersGaucheUn.Text = "< Un";
            this.btnVersGaucheUn.UseVisualStyleBackColor = true;
            // 
            // btnVersGaucheTous
            // 
            this.btnVersGaucheTous.ForeColor = System.Drawing.Color.Black;
            this.btnVersGaucheTous.Location = new System.Drawing.Point(281, 193);
            this.btnVersGaucheTous.Name = "btnVersGaucheTous";
            this.btnVersGaucheTous.Size = new System.Drawing.Size(122, 33);
            this.btnVersGaucheTous.TabIndex = 8;
            this.btnVersGaucheTous.Text = "<< Tous";
            this.btnVersGaucheTous.UseVisualStyleBackColor = true;
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 312);
            this.Controls.Add(this.btnVersGaucheTous);
            this.Controls.Add(this.btnVersGaucheUn);
            this.Controls.Add(this.btnVersDroiteTous);
            this.Controls.Add(this.btnVersDroiteUn);
            this.Controls.Add(this.btnTousLesExtraits);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlaylist";
            this.Text = "PLAYLIST des Extraits de l\'album ...";
            this.Load += new System.EventHandler(this.FrmPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Button btnTousLesExtraits;
        private System.Windows.Forms.Button btnVersDroiteUn;
        private System.Windows.Forms.Button btnVersDroiteTous;
        private System.Windows.Forms.Button btnVersGaucheUn;
        private System.Windows.Forms.Button btnVersGaucheTous;
        public System.Windows.Forms.ListBox lstGauche;
    }
}