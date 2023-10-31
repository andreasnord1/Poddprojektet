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

        public string Namn { get; set; }
        public int ID { get; set; }


        public Kategori()
        {
            Namn = string.Empty;
            ID = 0;
        }
        public Kategori(int id, string namn)
        {
            Namn = namn;
            ID = id;
        }

        // Andra relevanta egenskaper...

    }
}
