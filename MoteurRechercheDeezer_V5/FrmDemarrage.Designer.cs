
namespace ZiKnCo_MoteurRechercheDeezer
{
    partial class FrmDemarrage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteurMultimédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtisteInfos = new System.Windows.Forms.GroupBox();
            this.picIpod = new System.Windows.Forms.PictureBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.lblArtisteTrouve = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.tabDiscographie = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.listAlbum = new System.Windows.Forms.ListBox();
            this.lstTitre = new System.Windows.Forms.ListBox();
            this.txtTitre = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.Label();
            this.imgArtiste = new System.Windows.Forms.PictureBox();
            this.tbpRadio = new System.Windows.Forms.TabPage();
            this.wbRadio = new System.Windows.Forms.WebBrowser();
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.picBanniere = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipAppli = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIconEtat = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbpArtiste.SuspendLayout();
            this.grbArtisteInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.tabDiscographie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArtiste)).BeginInit();
            this.tbpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.contextMenuStripNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilToolStripMenuItem
            // 
            this.outilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecteurMultimédiaToolStripMenuItem,
            this.playListToolStripMenuItem});
            this.outilToolStripMenuItem.Name = "outilToolStripMenuItem";
            this.outilToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.outilToolStripMenuItem.Text = "Outil";
            // 
            // lecteurMultimédiaToolStripMenuItem
            // 
            this.lecteurMultimédiaToolStripMenuItem.Name = "lecteurMultimédiaToolStripMenuItem";
            this.lecteurMultimédiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lecteurMultimédiaToolStripMenuItem.Text = "Lecteur Multimédia";
            this.lecteurMultimédiaToolStripMenuItem.Click += new System.EventHandler(this.lecteurMultimédiaToolStripMenuItem_Click);
            // 
            // playListToolStripMenuItem
            // 
            this.playListToolStripMenuItem.Name = "playListToolStripMenuItem";
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playListToolStripMenuItem.Text = "PlayList";
            this.playListToolStripMenuItem.Click += new System.EventHandler(this.playListToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheAlbumToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            // 
            // rechercheAlbumToolStripMenuItem
            // 
            this.rechercheAlbumToolStripMenuItem.Name = "rechercheAlbumToolStripMenuItem";
            this.rechercheAlbumToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rechercheAlbumToolStripMenuItem.Text = "Recherche d\'Album";
            this.rechercheAlbumToolStripMenuItem.Click += new System.EventHandler(this.rechercheAlbumToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem1
            // 
            this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.aProposToolStripMenuItem1.Text = "A propos ...";
            this.aProposToolStripMenuItem1.Click += new System.EventHandler(this.aProposToolStripMenuItem1_Click);
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteRecherche.ForeColor = System.Drawing.Color.White;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(22, 140);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(98, 13);
            this.lblArtisteRecherche.TabIndex = 3;
            this.lblArtisteRecherche.Text = "Artiste Recherché :";
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.Location = new System.Drawing.Point(126, 137);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(158, 20);
            this.txtArtisteRecherche.TabIndex = 4;
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtisteRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(298, 135);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Go !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpArtiste);
            this.tbc.Controls.Add(this.tabDiscographie);
            this.tbc.Controls.Add(this.tbpRadio);
            this.tbc.Location = new System.Drawing.Point(14, 181);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(574, 238);
            this.tbc.TabIndex = 6;
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.Controls.Add(this.grbArtisteInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(566, 212);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Info Artiste";
            this.tbpArtiste.UseVisualStyleBackColor = true;
            // 
            // grbArtisteInfos
            // 
            this.grbArtisteInfos.Controls.Add(this.picIpod);
            this.grbArtisteInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtisteInfos.Controls.Add(this.lstArtistes);
            this.grbArtisteInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteTrouve);
            this.grbArtisteInfos.Controls.Add(this.picArtiste);
            this.grbArtisteInfos.Location = new System.Drawing.Point(7, 6);
            this.grbArtisteInfos.Name = "grbArtisteInfos";
            this.grbArtisteInfos.Size = new System.Drawing.Size(553, 200);
            this.grbArtisteInfos.TabIndex = 0;
            this.grbArtisteInfos.TabStop = false;
            this.grbArtisteInfos.Text = "Information Deezer";
            this.grbArtisteInfos.Visible = false;
            // 
            // picIpod
            // 
            this.picIpod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIpod.Image = ((System.Drawing.Image)(resources.GetObject("picIpod.Image")));
            this.picIpod.Location = new System.Drawing.Point(167, 159);
            this.picIpod.Name = "picIpod";
            this.picIpod.Size = new System.Drawing.Size(74, 35);
            this.picIpod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIpod.TabIndex = 7;
            this.picIpod.TabStop = false;
            this.toolTipAppli.SetToolTip(this.picIpod, "Accès au COVER FLOW (type IPOD...) ");
            this.picIpod.Click += new System.EventHandler(this.picIpod_Click);
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEcouterExtraits.Location = new System.Drawing.Point(6, 159);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(155, 35);
            this.btnEcouterExtraits.TabIndex = 6;
            this.btnEcouterExtraits.Text = "Écouter tous les extraits musicaux...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(6, 32);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(235, 121);
            this.lstArtistes.TabIndex = 5;
            this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged);
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(284, 181);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(64, 13);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien Deezer";
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(290, 10);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(66, 26);
            this.lblArtisteNom.TabIndex = 2;
            this.lblArtisteNom.Text = "NOM";
            // 
            // lblArtisteTrouve
            // 
            this.lblArtisteTrouve.AutoSize = true;
            this.lblArtisteTrouve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteTrouve.Location = new System.Drawing.Point(6, 16);
            this.lblArtisteTrouve.Name = "lblArtisteTrouve";
            this.lblArtisteTrouve.Size = new System.Drawing.Size(91, 13);
            this.lblArtisteTrouve.TabIndex = 1;
            this.lblArtisteTrouve.Text = "Artiste trouvé :";
            this.lblArtisteTrouve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picArtiste
            // 
            this.picArtiste.Image = ((System.Drawing.Image)(resources.GetObject("picArtiste.Image")));
            this.picArtiste.Location = new System.Drawing.Point(287, 41);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(132, 137);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 0;
            this.picArtiste.TabStop = false;
            // 
            // tabDiscographie
            // 
            this.tabDiscographie.Controls.Add(this.panel1);
            this.tabDiscographie.Location = new System.Drawing.Point(4, 22);
            this.tabDiscographie.Name = "tabDiscographie";
            this.tabDiscographie.Size = new System.Drawing.Size(566, 212);
            this.tabDiscographie.TabIndex = 2;
            this.tabDiscographie.Text = "Discographie";
            this.tabDiscographie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wmpLecteur);
            this.panel1.Controls.Add(this.listAlbum);
            this.panel1.Controls.Add(this.lstTitre);
            this.panel1.Controls.Add(this.txtTitre);
            this.panel1.Controls.Add(this.txtAlbum);
            this.panel1.Controls.Add(this.imgArtiste);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 206);
            this.panel1.TabIndex = 0;
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(8, 149);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(548, 43);
            this.wmpLecteur.TabIndex = 5;
            // 
            // listAlbum
            // 
            this.listAlbum.FormattingEnabled = true;
            this.listAlbum.Location = new System.Drawing.Point(113, 22);
            this.listAlbum.Name = "listAlbum";
            this.listAlbum.Size = new System.Drawing.Size(216, 121);
            this.listAlbum.TabIndex = 4;
            this.listAlbum.SelectedIndexChanged += new System.EventHandler(this.listAlbum_SelectedIndexChanged);
            this.listAlbum.DoubleClick += new System.EventHandler(this.listAlbum_DoubleClick);
            // 
            // lstTitre
            // 
            this.lstTitre.FormattingEnabled = true;
            this.lstTitre.Location = new System.Drawing.Point(335, 22);
            this.lstTitre.Name = "lstTitre";
            this.lstTitre.Size = new System.Drawing.Size(221, 121);
            this.lstTitre.TabIndex = 3;
            this.lstTitre.Click += new System.EventHandler(this.lstTitre_Click);
            this.lstTitre.SelectedIndexChanged += new System.EventHandler(this.lstTitre_SelectedIndexChanged);
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.Location = new System.Drawing.Point(333, 6);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(28, 13);
            this.txtTitre.TabIndex = 2;
            this.txtTitre.Text = "Titre";
            // 
            // txtAlbum
            // 
            this.txtAlbum.AutoSize = true;
            this.txtAlbum.Location = new System.Drawing.Point(111, 6);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(36, 13);
            this.txtAlbum.TabIndex = 1;
            this.txtAlbum.Text = "Album";
            // 
            // imgArtiste
            // 
            this.imgArtiste.Location = new System.Drawing.Point(8, 18);
            this.imgArtiste.Name = "imgArtiste";
            this.imgArtiste.Size = new System.Drawing.Size(100, 125);
            this.imgArtiste.TabIndex = 0;
            this.imgArtiste.TabStop = false;
            // 
            // tbpRadio
            // 
            this.tbpRadio.Controls.Add(this.wbRadio);
            this.tbpRadio.Location = new System.Drawing.Point(4, 22);
            this.tbpRadio.Name = "tbpRadio";
            this.tbpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRadio.Size = new System.Drawing.Size(566, 212);
            this.tbpRadio.TabIndex = 1;
            this.tbpRadio.Text = "Radio Artiste";
            this.tbpRadio.UseVisualStyleBackColor = true;
            // 
            // wbRadio
            // 
            this.wbRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbRadio.Location = new System.Drawing.Point(3, 3);
            this.wbRadio.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbRadio.Name = "wbRadio";
            this.wbRadio.ScriptErrorsSuppressed = true;
            this.wbRadio.ScrollBarsEnabled = false;
            this.wbRadio.Size = new System.Drawing.Size(560, 206);
            this.wbRadio.TabIndex = 0;
            // 
            // picDeezer
            // 
            this.picDeezer.Image = ((System.Drawing.Image)(resources.GetObject("picDeezer.Image")));
            this.picDeezer.Location = new System.Drawing.Point(439, 124);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(153, 33);
            this.picDeezer.TabIndex = 2;
            this.picDeezer.TabStop = false;
            this.picDeezer.Click += new System.EventHandler(this.picDeezer_Click);
            // 
            // picBanniere
            // 
            this.picBanniere.Image = ((System.Drawing.Image)(resources.GetObject("picBanniere.Image")));
            this.picBanniere.Location = new System.Drawing.Point(14, 36);
            this.picBanniere.Name = "picBanniere";
            this.picBanniere.Size = new System.Drawing.Size(578, 67);
            this.picBanniere.TabIndex = 1;
            this.picBanniere.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(129, 160);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erp.ContainerControl = this;
            // 
            // toolTipAppli
            // 
            this.toolTipAppli.IsBalloon = true;
            this.toolTipAppli.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAppli.ToolTipTitle = "Pour info";
            // 
            // notifyIconEtat
            // 
            this.notifyIconEtat.ContextMenuStrip = this.contextMenuStripNotification;
            this.notifyIconEtat.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEtat.Icon")));
            this.notifyIconEtat.Text = "ZiK\'nCo - Moteur de recherche DEEZER";
            this.notifyIconEtat.Visible = true;
            // 
            // contextMenuStripNotification
            // 
            this.contextMenuStripNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.masquerToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.contextMenuStripNotification.Name = "contextMenuStripNotification";
            this.contextMenuStripNotification.Size = new System.Drawing.Size(181, 92);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // masquerToolStripMenuItem
            // 
            this.masquerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masquerToolStripMenuItem.Image")));
            this.masquerToolStripMenuItem.Name = "masquerToolStripMenuItem";
            this.masquerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masquerToolStripMenuItem.Text = "Masquer";
            this.masquerToolStripMenuItem.Click += new System.EventHandler(this.masquerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem1.Image")));
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.picBanniere);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDemarrage";
            this.Text = "Moteur de recherche DEEZER : Version 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemarrage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.Click += new System.EventHandler(this.FrmDemarrage_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc.ResumeLayout(false);
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtisteInfos.ResumeLayout(false);
            this.grbArtisteInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.tabDiscographie.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgArtiste)).EndInit();
            this.tbpRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.contextMenuStripNotification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteurMultimédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
        private System.Windows.Forms.PictureBox picBanniere;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.GroupBox grbArtisteInfos;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.TabPage tbpRadio;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.Label lblArtisteTrouve;
        private System.Windows.Forms.WebBrowser wbRadio;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.TabPage tabDiscographie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listAlbum;
        private System.Windows.Forms.ListBox lstTitre;
        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Label txtAlbum;
        private System.Windows.Forms.PictureBox imgArtiste;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIpod;
        private System.Windows.Forms.ToolTip toolTipAppli;
        private System.Windows.Forms.NotifyIcon notifyIconEtat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotification;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}

