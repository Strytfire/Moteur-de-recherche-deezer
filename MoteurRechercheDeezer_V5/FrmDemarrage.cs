using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;
using System.Diagnostics;
using System.Media;

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmDemarrage : Form
    {
        #region Champ
        Artist selectedArtist = new Artist();
        Artist selectedArtistDetails = new Artist();
        private Album selectedAlbum = new Album();
        Album selectedAlbumdetails = new Album();
        private Track selectedtrack = new Track();
        #endregion 
        #region Constructeur
        public FrmDemarrage()
        {
            InitializeComponent();
        }
        #endregion Constructeur
        #region Méthodes gestionnaire d’évènements
        #region Traitement principal : Clic sur le bouton btnRechercher
        //Evenement a l'appui du Bouton Go!
        private void btnRechercher_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            lblMessage.Text = "Recherche en cours, veuillez patienter...";
            lblMessage.Refresh();


            List<Artist> lesArtistes = new List<Artist>();
            string recherche = txtArtisteRecherche.Text;
            lesArtistes = DeezerApi.getAllArtistsByName(recherche);
            RechercheArtiste(lesArtistes, recherche);

        }

        private void RechercheArtiste(List<Artist> lesArtistes, string recherche)
        {
            if (lesArtistes.Count == 0)
            {
                erp.SetError(txtArtisteRecherche, string.Empty);
                if (txtArtisteRecherche.Text == string.Empty)
                {
                    erp.SetError(txtArtisteRecherche, "Aucun titre indiqué");
                }
                //MessageBox.Show("Désolé, artiste '" + recherche + "' inconnu sur Deezer ...", "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMessage.Text = "Désolé, l'artiste '" + recherche + "' est inconnu sur Deezer ...";


            }
            else
            {
                erp.SetError(txtArtisteRecherche, string.Empty);
                lstArtistes.DataSource = lesArtistes;
                lstArtistes.DisplayMember = "name";
                grbArtisteInfos.Visible = true;
                lblMessage.Text = string.Empty;
                txtArtisteRecherche.Text = string.Empty;

            }
        }

        //Évenement pour activer la recherche par le bouton "Entrée"
        private void txtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        #endregion

        #region Traitement des menu
        //Évenement qui permet de Clic sur le lien deezer
        private void picDeezer_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.deezer.com/fr/");
        }

        #endregion



        private void FrmDemarrage_Click(object sender, EventArgs e)
        {
            txtArtisteRecherche.Focus();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "ZiK'nCo : question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); }
        }

        private void lecteurMultimédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            formulaire.Show();
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrrPropos formulaire = new FrrPropos(); formulaire.Show();
        }

        private void lstArtistes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listAlbum.DataSource = selectedArtistDetails.getLesAlbums();
                listAlbum.DisplayMember = "title";
                lblArtisteNom.Text = selectedArtist.name;
                lklDeezerLien.Text = selectedArtist.link;
                picArtiste.ImageLocation = selectedArtist.picture;
                string urlWidget = DeezerPlugin.getUrlPluginRadio(selectedArtist.id); wbRadio.Navigate(urlWidget);
            }
            catch (Exception)
            {

            }
            selectedArtist = (Artist)lstArtistes.SelectedItem;






            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selectedArtistDetails.nbAlbums == 0)
            {
                MessageBox.Show("Désolé, les extraits pour '" + selectedArtist.name + "' ne sont pas disponibles...", "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Album> LesAlbums = selectedArtistDetails.getLesAlbums();
                foreach (Album unAlbum in LesAlbums)
                {
                    List<Track> LesTracks = unAlbum.getLesTracks();
                    foreach (Track unTrack in LesTracks)
                    {

                        WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                    }
                }
                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }


        private void listAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)listAlbum.SelectedItem;

            lstTitre.DataSource = selectedAlbum.getLesTracks();
            lstTitre.DisplayMember = "title";
            imgArtiste.ImageLocation = selectedAlbum.cover;


        }

        private void lstTitre_Click(object sender, EventArgs e)
        {
            selectedtrack = (Track)lstTitre.SelectedItem;
            wmpLecteur.URL = selectedtrack.preview;

        }

        private void RheAlbtoolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void rechercheAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercheAlbums formulaire = new FrmRechercheAlbums();
            formulaire.Show();
        }

        private void lstTitre_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedtrack = (Track)lstTitre.SelectedItem;
            wmpLecteur.URL = selectedtrack.preview;
        }
        private void FrmDemarrage_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "ZiK'nCo : question",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;

        }

        private void listAlbum_DoubleClick(object sender, EventArgs e)
        {
            FrmPlaylist formulaire = new FrmPlaylist();
            List<Track> lesTracks = selectedAlbum.getLesTracks(); //Liste des titres de l'album sélectionné
            foreach (Track unTrack in lesTracks)
            { //Remplissage de la liste de gauche du formulaire FrmPlaylist (propriété Modifiers : Public)
                formulaire.lstGauche.Items.Add(unTrack);
                formulaire.lstGauche.DisplayMember = "title"; //Le nom du titre sera affiché
            }
            formulaire.Show(); //Affichage du formulaire
        }

        private void playListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlaylist formulaire = new FrmPlaylist();
            formulaire.Show();
        }

        #endregion

        private void picIpod_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmCoverFlow formulaire = new FrmCoverFlow();
            formulaire.selectedArtistDetails = this.selectedArtistDetails;
            formulaire.Show();
            this.Cursor = Cursors.Default;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ErrorConnection()
        {
            notifyIconEtat.ShowBalloonTip(10000, "Connexion Internet inactive !", "La recherche sur le site DEEZER est Impossible", ToolTipIcon.Error);
            System.Media.SystemSounds.Exclamation.Play();

        }
        private void Hello()
        {
            string Date = DateTime.Now.ToString("dd/MM/yyyy");
            string Heure = DateTime.Now.ToString("HH:mm:ss");
            notifyIconEtat.ShowBalloonTip(10000, "Bienvenue " + Environment.UserName, "Appli Zik'nCo Deezer Lançée le " + Date + " à " + Heure, ToolTipIcon.Info);
            System.Media.SystemSounds.Exclamation.Play();
        }


        private void FrmDemarrage_Load(object sender, EventArgs e)
        {
            if (!NetManager.isConnected())
            {
                ErrorConnection();
                Application.Exit();
            }
            else
                Hello();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void masquerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

   