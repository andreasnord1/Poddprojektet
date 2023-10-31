using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Models
{
    [Serializable]

    public class Podcast
    {
        public int ID { get; set; }
        public string? Url { get; set; }
        public string Namn { get; set; }
        public string? Titel { get; set; }
        public Kategori PodcastKategori { get; set; }
        public List<Avsnitt> Avsnitt { get; set; }
        public string? Beskrivning { get; set; }
        public string Author { get; set; }
        public string BildUrl { get; set; }

        // public string CustomName { get; set; }
        // public int KategoriID { get; set; }


        public Podcast(string url, string namn, string titel, string beskrivning, string author, 
            string bildUrl, Kategori kategori, List<Avsnitt> avsnittsLista)
        {
            Url = url;
            Namn = namn;
            Titel = titel;
            Beskrivning = beskrivning;
            Author = author;
            BildUrl = bildUrl;
            PodcastKategori = kategori;
            Avsnitt = avsnittsLista;
        }

        public Podcast()
        {

        }


        //public Podcast()
        //{
        //    Avsnitt = new List<Avsnitt>();

        //    Namn = string.Empty;
        //    Author = string.Empty;
        //    BildUrl = string.Empty;
        //    // CustomName = string.Empty;
        //}



        // Andra relevanta egenskaper...

    }
}