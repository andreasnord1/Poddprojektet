using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Avsnitt
    {

        private int ID { get; }
        public string? Titel { get; set; }
        public DateTimeOffset PubliceringsDatum { get; set; }
        public string? Beskrivning { get; set; }

        private static int nastaID = 0;

        public Avsnitt(string titel, DateTimeOffset datum, string beskrivning)
        {
            Titel = titel;
            PubliceringsDatum = datum;
            Beskrivning = beskrivning;
            ID = nastaID++;
        }

        public Avsnitt()
        {

        }



        // Andra relevanta egenskaper...

    }
}
