using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;

namespace ZiKnCo_MoteurRechercheDeezer

{

    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmDemarrage());


            //List<Artist> lesArtistes = new List<Artist>();
            //lesArtistes = DeezerApi.getAllArtistsByName("Bob");

            //Console.WriteLine(lesArtistes[0].name);

            #region Test sur le parcours de collection
            ////for (i = 0; i <= lesArtistes.Count - 1; i++)
            ////while (i <= lesArtistes.Count - 1)  
            //foreach (Artist unArtiste in lesArtistes)
            //{
            //    Console.WriteLine(unArtiste.name);
            //    //i++;//i=i+1;
            //}
            //#endregion



            //#region


            //if (!NetManager.isConnected())
            //{
            //    MessageBox.Show("Non connecté");
            //}
            //else
            //{
            //    Artist monArtist = new Artist();
            //    string recherche = "zaz";
            //    monArtist = DeezerApi.getFirstArtistByName(recherche);



            //    if (monArtist == null)

            //    {
            //        Console.WriteLine("Désolé, artiste " + recherche + "inconnue sur Deezer");
            //    }

            //    else

            //        Console.WriteLine("Information du premier artiste trouvé :");
            //    Console.WriteLine("---------------------------------------");
            //    Console.WriteLine("Nom :" + monArtist.name);
            //    Console.WriteLine("ID: " + monArtist.id);
            //    Console.WriteLine("Lien de ça photo :" + monArtist.picture);
            //    Console.WriteLine("Lien deezer : " + monArtist.link);
            //    Console.WriteLine("Lien du PLUGIN de la RADIO de l’artiste : " + DeezerPlugin.getUrlPluginRadio(monArtist.id));
            #endregion

            #region Exercice 1

            //Artist LeArticte = DeezerApi.getFirstArtistByName("vaughan");

            //Console.WriteLine(LeArticte.picture);

            #endregion

            #region Exercice 2

            //List<Album> LesAlbums = DeezerApi.getAllAlbumsByName("djangoly");
            //Album premierAlbum = LesAlbums[0];
            //Console.WriteLine(premierAlbum.title);

            #endregion

            #region Exercice 3

            //Console.WriteLine(premierAlbum.theArtist.name);

            #endregion

            #region Exercice 4
            //List<Track> lesTracks = DeezerApi.getAllTracksByName("Minor Swing");
            //Console.WriteLine(lesTracks[0].theArtist.name);

            #endregion

            #region Exercice 5

            //List<Album> Lesalbums = DeezerApi.getAllAlbumsByName("Bande Originel");

            //foreach (Album unAlbum in Lesalbums )
            //{
            //    Console.WriteLine(unAlbum.cover);
            //}

            #endregion

            #region Exercice 6

            //List<Album> Lesalbums = DeezerApi.getAllAlbumsByName("Bande Originel");

            //int i = 0;
            //for (i = 0; i < 3; i++) 
            //{
            //    Console.WriteLine(Lesalbums[i].cover);
            //}

            #endregion

            #region Exercice 7

            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByName("Bande Originel");
            //int i = 0;
            //while (i<3)
            //{
            //    Console.WriteLine(lesAlbums[i].cover);
            //    i++;
            //}

            //#endregion

            //#region Exercice 8

            //Artist Stromae = DeezerApi.getFirstArtistByName("stromae");

            //////Récupération des info detailléspour connaitre la disco
            //Artist stromaeDetails = DeezerApi.getDetailsArtistById(Stromae.id);

            //List<Album> lesalbumsdestromae = stromaeDetails.getLesAlbums();


            #endregion
        }

    }

}

    