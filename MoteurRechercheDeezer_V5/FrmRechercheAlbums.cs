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

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmRechercheAlbums : Form
    {
        private Album selectedAlbum = new Album();
        Artist selectedArtistDetails = new Artist();
        Artist selectedArtist = new Artist();
        private Track selectedtrack = new Track();
        public FrmRechercheAlbums()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MsgAtt.Visible = true;
            MsgAtt.Text = "Recherche en cours, veuillez patienter...";
            MsgAtt.Refresh();

            List<Album> lesAlbum = new List<Album>();
            string recherche = TxtBoxAlbum.Text;
            lesAlbum = DeezerApi.getAllAlbumsByName(recherche);

            if (lesAlbum.Count == 0)
            {
                erp2.SetError(TxtBoxAlbum, string.Empty);
                if (TxtBoxAlbum.Text == string.Empty)
                {
                    erp2.SetError(TxtBoxAlbum, "Aucun titre indiqué");
                }
                //MessageBox.Show("Désolé, artiste '" + recherche + "' inconnu sur Deezer ...", "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MsgAtt.Text = "Désolé, l'artiste '" + recherche + "' est inconnu sur Deezer ...";


            }
            else
            {
                erp2.SetError(TxtBoxAlbum, string.Empty);
                lbAlbum.DataSource = lesAlbum;
                lbAlbum.DisplayMember = "title";
                grpInfDee.Visible = true;
                MsgAtt.Text = string.Empty;
                TxtBoxAlbum.Text = string.Empty;

            }

        }

        private void lbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affiche la photo de L'album
            selectedAlbum = (Album)lbAlbum.SelectedItem;
            selectedAlbum = DeezerApi.getDetailsAlbumById(selectedAlbum.id);
            lbtitrealbum.DataSource = selectedAlbum.getLesTracks();
            lbtitrealbum.DisplayMember = "title";
            imgAlbum.ImageLocation = selectedAlbum.cover;

            lbtitrealbum.DataSource = selectedAlbum.getLesTracks();
            selectedArtist = selectedAlbum.theArtist;
            imgArti.ImageLocation = selectedArtist.picture;

            lblname.Text = selectedAlbum.title;
            lblnameart.Text = selectedArtist.name;
            lklDeezerLien.Text = selectedAlbum.link;
        }

        private void lklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lklDeezerLien.Text);
        }

        private void lbtitrealbum_Click(object sender, EventArgs e)
        {
            selectedtrack = (Track)lbtitrealbum.SelectedItem;
            wmpLecteur.URL = selectedtrack.preview;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            formulaire.Show();
        }

        private void TxtBoxAlbum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) BtnGo.PerformClick();
        }

        
    }
}
