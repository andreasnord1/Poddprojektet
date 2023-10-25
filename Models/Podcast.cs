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
        public int ID;

        public string? Url { get; set; }
        public string Namn { get; set; }
        public string? Titel { get; set; }
        public Kategori? PodcastKategori { get; set; }
        public List<Avsnitt>? Avsnitt { get; set; }
        public string? Beskrivning { get; set; }
        public string Author { get; set; }

        public string CustomName { get; set; }

        // Andra relevanta egenskaper...

        public Podcast()
        {
            Avsnitt = new List<Avsnitt>();
        }

    }
}