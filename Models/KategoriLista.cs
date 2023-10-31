using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{

    [XmlRoot("Categories")]
    public class KategoriLista
    {

        [XmlElement("Category")]
        public List<string> Categories { get; set; }


        public KategoriLista()
        {
            Categories = new List<string>();
        }




    }

}
