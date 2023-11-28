
namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmRechercheAlbums
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheAlbums));
            this.TxtBoxAlbum = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.lblRch = new System.Windows.Forms.Label();
            this.grpInfDee = new System.Windows.Forms.GroupBox();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblnameart = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.imgArti = new System.Windows.Forms.PictureBox();
            this.imgAlbum = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tda = new System.Windows.Forms.Label();
            this.Salbum = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.ListBox();
            this.lbtitrealbum = new System.Windows.Forms.ListBox();
            this.MsgAtt = new System.Windows.Forms.Label();
            this.erp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpInfDee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxAlbum
            // 
            this.TxtBoxAlbum.Location = new System.Drawing.Point(125, 32);
            this.TxtBoxAlbum.Name = "TxtBoxAlbum";
            this.TxtBoxAlbum.Size = new System.Drawing.Size(141, 20);
            this.TxtBoxAlbum.TabIndex = 0;
            this.TxtBoxAlbum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxAlbum_KeyPress);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(290, 30);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go!";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // lblRch
            // 
            this.lblRch.AutoSize = true;
            this.lblRch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRch.Location = new System.Drawing.Point(21, 34);
            this.lblRch.Name = "lblRch";
            this.lblRch.Size = new System.Drawing.Size(98, 13);
            this.lblRch.TabIndex = 2;
            this.lblRch.Text = "Album Recherché :";
            // 
            // grpInfDee
            // 
            this.grpInfDee.BackColor = System.Drawing.SystemColors.Control;
            this.grpInfDee.Controls.Add(this.lklDeezerLien);
            this.grpInfDee.Controls.Add(this.wmpLecteur);
            this.grpInfDee.Controls.Add(this.lblnameart);
            this.grpInfDee.Controls.Add(this.lblname);
            this.grpInfDee.Controls.Add(this.imgArti);
            this.grpInfDee.Controls.Add(this.imgAlbum);
            this.grpInfDee.Controls.Add(this.button1);
            this.grpInfDee.Controls.Add(this.Tda);
            this.grpInfDee.Controls.Add(this.Salbum);
            this.grpInfDee.Controls.Add(this.lbAlbum);
            this.grpInfDee.Controls.Add(this.lbtitrealbum);
            this.grpInfDee.Location = new System.Drawing.Point(12, 81);
            this.grpInfDee.Name = "grpInfDee";
            this.grpInfDee.Size = new System.Drawing.Size(776, 357);
            this.grpInfDee.TabIndex = 3;
            this.grpInfDee.TabStop = false;
            this.grpInfDee.Text = "Information DEEZER";
            this.grpInfDee.Visible = false;
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(390, 167);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(114, 13);
            this.lklDeezerLien.TabIndex = 10;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien de l\'album Deezer";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerLien_LinkClicked);
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(375, 253);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(394, 46);
            this.wmpLecteur.TabIndex = 9;
            // 
            // lblnameart
            // 
            this.lblnameart.AutoSize = true;
            this.lblnameart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnameart.Location = new System.Drawing.Point(523, 65);
            this.lblnameart.Name = "lblnameart";
            this.lblnameart.Size = new System.Drawing.Size(61, 13);
            this.lblnameart.TabIndex = 8;
            this.lblnameart.Text = "Nom Artiste";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(390, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 13);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Nom Album";
            // 
            // imgArti
            // 
            this.imgArti.Location = new System.Drawing.Point(526, 81);
            this.imgArti.Name = "imgArti";
            this.imgArti.Size = new System.Drawing.Size(100, 84);
            this.imgArti.TabIndex = 6;
            this.imgArti.TabStop = false;
            // 
            // imgAlbum
            // 
            this.imgAlbum.Location = new System.Drawing.Point(390, 55);
            this.imgAlbum.Name = "imgAlbum";
            this.imgAlbum.Size = new System.Drawing.Size(116, 110);
            this.imgAlbum.TabIndex = 5;
            this.imgAlbum.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(376, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Écouter tous les extraits d\'album...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tda
            // 
            this.Tda.AutoSize = true;
            this.Tda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tda.Location = new System.Drawing.Point(12, 198);
            this.Tda.Name = "Tda";
            this.Tda.Size = new System.Drawing.Size(105, 17);
            this.Tda.TabIndex = 3;
            this.Tda.Text = "Titres De L\'album : ";
            this.Tda.UseCompatibleTextRendering = true;
            // 
            // Salbum
            // 
            this.Salbum.AutoSize = true;
            this.Salbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salbum.Location = new System.Drawing.Point(12, 27);
            this.Salbum.Name = "Salbum";
            this.Salbum.Size = new System.Drawing.Size(99, 13);
            this.Salbum.TabIndex = 2;
            this.Salbum.Text = "Albums Trouvé :";
            // 
            // lbAlbum
            // 
            this.lbAlbum.BackColor = System.Drawing.SystemColors.GrayText;
            this.lbAlbum.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbAlbum.FormattingEnabled = true;
            this.lbAlbum.Location = new System.Drawing.Point(12, 46);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(357, 134);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.SelectedIndexChanged += new System.EventHandler(this.lbAlbum_SelectedIndexChanged);
            // 
            // lbtitrealbum
            // 
            this.lbtitrealbum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbtitrealbum.FormattingEnabled = true;
            this.lbtitrealbum.Location = new System.Drawing.Point(12, 217);
            this.lbtitrealbum.Name = "lbtitrealbum";
            this.lbtitrealbum.Size = new System.Drawing.Size(357, 134);
            this.lbtitrealbum.TabIndex = 0;
            this.lbtitrealbum.Click += new System.EventHandler(this.lbtitrealbum_Click);
            // 
            // MsgAtt
            // 
            this.MsgAtt.AutoSize = true;
            this.MsgAtt.ForeColor = System.Drawing.Color.OrangeRed;
            this.MsgAtt.Location = new System.Drawing.Point(122, 55);
            this.MsgAtt.Name = "MsgAtt";
            this.MsgAtt.Size = new System.Drawing.Size(116, 13);
            this.MsgAtt.TabIndex = 4;
            this.MsgAtt.Text = "Recherche en cours ...";
            this.MsgAtt.Visible = false;
            // 
            // erp2
            // 
            this.erp2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRechercheAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MsgAtt);
            this.Controls.Add(this.grpInfDee);
            this.Controls.Add(this.lblRch);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.TxtBoxAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRechercheAlbums";
            this.Text = "Recherche d\'Albums";
            this.grpInfDee.ResumeLayout(false);
            this.grpInfDee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxAlbum;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Label lblRch;
        private System.Windows.Forms.GroupBox grpInfDee;
        private System.Windows.Forms.Label Tda;
        private System.Windows.Forms.Label Salbum;
        private System.Windows.Forms.ListBox lbAlbum;
        private System.Windows.Forms.ListBox lbtitrealbum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgArti;
        private System.Windows.Forms.PictureBox imgAlbum;
        private System.Windows.Forms.Label lblnameart;
        private System.Windows.Forms.Label lblname;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label MsgAtt;
        private System.Windows.Forms.ErrorProvider erp2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}