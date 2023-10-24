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


        public Avsnitt() { }
        public string? Titel { get; set; }
        public DateTime? PubliceringsDatum { get; set; }
        public string? Beskrivning { get; set; }
        
        // Andra relevanta egenskaper...

    }
}
