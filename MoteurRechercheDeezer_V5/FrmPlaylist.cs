using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiKnCo_MoteurRechercheDeezer
{
    public partial class FrmPlaylist : Form
    {
        public FrmPlaylist()
        {
            InitializeComponent();
            btnVersDroiteUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheTous.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersDroiteTous.Click += new System.EventHandler(boutonsTransfert_Click);
        }

        
        #region Méthode
        private void FrmPlaylist_Load(object sender, EventArgs e)
        {
           // for (int i = 1; i < 11; i++)
            //lstGauche.Items.Add("Titre" + i);
            lstGauche.SelectedIndex = 0;
            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;

        }
        #region Méthode Procédure
        enum ModeTransfert
        {
            Un,
            Tous,
            Certains
        }
        private void transferer(ListBox lstSource, ListBox lstDestination, ModeTransfert mode)
        {
            switch (mode)
            {
                case ModeTransfert.Un:
                    lstDestination.Items.Add(lstSource.SelectedItem);
                    lstSource.Items.Remove(lstSource.SelectedItem);
                    break;
                case ModeTransfert.Tous:
                    foreach (object element in lstDestination.Items)
                    lstSource.Items.Add(element);
                    lstDestination.Items.Clear();
                    break;
                case ModeTransfert.Certains: //non traité pour l'instant
                    break;
            }
            if (lstDestination.Items.Count > 0)
                lstDestination.SelectedIndex = lstDestination.Items.Count - 1;
            if (lstSource.Items.Count > 0)
                lstSource.SelectedIndex = lstSource.Items.Count - 1;

        }
        private void boutonsTransfert_Click(object sender, EventArgs e)
        {
            Button boutonDeclencheur = (Button)(sender);
            switch (boutonDeclencheur.Name)
            {
                case "btnVersDroiteUn":
                    transferer(lstGauche, lstDroite, ModeTransfert.Un);
                    break;
                case "btnVersDroiteTous":
                    transferer(lstDroite, lstGauche, ModeTransfert.Tous);
                    break;
                case "btnVersGaucheUn":
                    transferer(lstDroite, lstGauche, ModeTransfert.Un);
                    break;
                case "btnVersGaucheTous":
                    transferer(lstGauche, lstDroite, ModeTransfert.Tous);
                    break;
            }
        }

        #endregion

        #endregion

        private void lstGauche_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;
            btnVersDroiteUn.Enabled = true;
            btnVersDroiteTous.Enabled = true;

            if (lstGauche.SelectedIndex == -1)
            {
                btnVersGaucheUn.Enabled = false;
                btnVersGaucheTous.Enabled = false;
            }
            if (lstDroite.SelectedIndex > 0 )
            {
                btnVersGaucheTous.Enabled = true;
            }
        }

        private void lstDroite_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            btnVersGaucheUn.Enabled = true;
            btnVersGaucheTous.Enabled = true;
            btnVersDroiteUn.Enabled = false;
            btnVersDroiteTous.Enabled = false;

            if (lstDroite.SelectedIndex== -1)
            {
                btnVersGaucheUn.Enabled = false;
                btnVersGaucheTous.Enabled = false;
            }
            if (lstGauche.SelectedIndex > 0 )
            {
                btnVersDroiteTous.Enabled= true;
            }

        }

        private void btnTousLesExtraits_Click(object sender, EventArgs e)
        {
            if (lstDroite.SelectedIndex == -1)
            {
                MessageBox.Show("Aucun titre selectionné", "PlayList");
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                formulaire.Show();

                foreach (Track UTrack in lstDroite.Items)
                { 
                WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(UTrack.preview);
                formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                }
            }
        }
    }
}
