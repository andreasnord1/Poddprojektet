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
        public Kategori(int id, string namn)
        {
            Namn = namn;
            ID = id;
        }

        public string Namn { get; set; }
        public int ID { get; set; }
        // Andra relevanta egenskaper...

    }
}
