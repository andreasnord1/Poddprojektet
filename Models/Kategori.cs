using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Models
{
    [Serializable]


    public class Kategori
    {
        public Kategori(string namn)
        {
            Namn = namn;
        }

        public Kategori()
        {

        }

        public string Namn { get; set; }
        // Andra relevanta egenskaper...

    }
}
