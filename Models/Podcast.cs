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
        public string Namn { get; set; } = string.Empty;  // Standardvärde
        public string? Titel { get; set; }
        public Kategori PodcastKategori { get; set; } = new Kategori();  // Standardvärde
        public List<Avsnitt> Avsnitt { get; set; } = new List<Avsnitt>();  // Initialiserar till tom lista
        public string? Beskrivning { get; set; }
        public string Author { get; set; } = string.Empty;  // Standardvärde
        public string BildUrl { get; set; } = string.Empty;  // Standardvärde
        public string KategoriNamn
        {
            get { return PodcastKategori.Namn; }
        }

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
    }
}
