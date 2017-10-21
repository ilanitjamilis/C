using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTercerTrimestre_IlanitJamilis
{
    public partial class Form1 : Form
    {
        List<Artista> listaArtistas = new List<Artista>();
        string error = "";
        bool artistaEncontrado = false;
        bool albumEncontrado = false;
        Album oAlbum = new Album();
        Artista oArtista = new Artista();
        int cantTotalReproducciones = 0;
        Album albumMasEscuchado = new Album();
        Album albumMenosCanciones = new Album();
        int cantReproduccionesArtista = 0;
        Artista artistaMasEscuchado = new Artista();
        int auxReproduccionesArtistaMasEscuchado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            error="";
            if(txtArtista.Text.Trim()=="")
            {
                error += "Ingrese artista.\n";
            }
            if(txtAlbum.Text.Trim()=="")
            {
                error += "Ingrese álbum.\n";
            }
            if(nudCantCanciones.Value<1)
            {
                error += "Cantidad de canciones incorrecta.\n";
            }
            if(nudCantReproducciones.Value<1)
            {
                error+= "Cantidad de reproducciones incorrecta.\n";
            }

            if(error=="")
            {
                artistaEncontrado = false;
                foreach(Artista oArtista in listaArtistas)
                {
                    if(oArtista.nombre==txtArtista.Text.Trim())
                    {
                        artistaEncontrado=true;
                        albumEncontrado = false;
                        foreach(Album oAlbum in oArtista.listaAlbumes)
                        {
                            if(oAlbum.nombre==txtAlbum.Text.Trim())
                            {
                                albumEncontrado=true;
                                oAlbum.cantReproducciones+=Convert.ToInt32(nudCantReproducciones.Value);
                                MessageBox.Show("Álbum cargado anteriormente. Solamente se tuvo en cuenta la cantidad de reproducciones; no la cantidad de canciones.", "ADVERTENCIA");
                            }
                        }
                        if(albumEncontrado==false)
                        {
                            oAlbum=new Album();
                            oAlbum.nombre=txtAlbum.Text.Trim();
                            oAlbum.cantCanciones=Convert.ToInt32(nudCantCanciones.Value);
                            oAlbum.cantReproducciones=Convert.ToInt32(nudCantReproducciones.Value);
                            oArtista.listaAlbumes.Add(oAlbum);
                        }
                    }
                }
                if(artistaEncontrado==false)
                {
                    oAlbum=new Album();
                    oAlbum.nombre=txtAlbum.Text.Trim();
                    oAlbum.cantCanciones=Convert.ToInt32(nudCantCanciones.Value);
                    oAlbum.cantReproducciones=Convert.ToInt32(nudCantReproducciones.Value);

                    oArtista=new Artista();
                    oArtista.nombre=txtArtista.Text.Trim();
                    oArtista.listaAlbumes= new List<Album>();
                    oArtista.listaAlbumes.Add(oAlbum);

                    listaArtistas.Add(oArtista);
                }

                MessageBox.Show("Carga realizada correctamente.");

                txtArtista.Text="";
                txtAlbum.Text="";
                nudCantCanciones.Text="0";
                nudCantReproducciones.Text="0";
            }
            else
            {
                MessageBox.Show(error,"ERROR");
            }
        }

        private void btnVerInformacion_Click(object sender, EventArgs e)
        {
            cantTotalReproducciones = 0;
            albumMenosCanciones.cantCanciones = 99;
            foreach(Artista oArtista in listaArtistas)
            {
                cantReproduccionesArtista = 0;
                foreach(Album oAlbum in oArtista.listaAlbumes)
                {
                    cantTotalReproducciones += oAlbum.cantReproducciones;

                    if (oAlbum.cantReproducciones > albumMasEscuchado.cantReproducciones)
                    {
                        albumMasEscuchado = oAlbum;
                    }

                    if(oAlbum.cantCanciones<albumMenosCanciones.cantCanciones)
                    {
                        albumMenosCanciones = oAlbum;
                    }

                    cantReproduccionesArtista += oAlbum.cantReproducciones;
                }
                if(cantReproduccionesArtista>auxReproduccionesArtistaMasEscuchado)
                {
                    auxReproduccionesArtistaMasEscuchado = cantReproduccionesArtista;
                    artistaMasEscuchado = oArtista;
                }
            }

            MessageBox.Show("Cantidad total de reproducciones: "+cantTotalReproducciones+".\n" + 
            "Álbum más escuchado: " + albumMasEscuchado.nombre + ". Cantidad de reproducciones: " + albumMasEscuchado.cantReproducciones+".\n" 
            + "Álbum con menos canciones: "+albumMenosCanciones.nombre+". Cantidad de canciones: " + albumMenosCanciones.cantCanciones+".\n"
            + "Artista más escuchado: "+artistaMasEscuchado.nombre+". Cantidad de reproducciones: "+auxReproduccionesArtistaMasEscuchado+"." , "INFORMACIÓN GENERAL");
        }
    }
}
