using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;

namespace DataAccessLayer
{
    internal class Serialiserare
    {
        public void SerialiseraPodcasts(List<Podcast> podcastLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream sparningsFil = new FileStream("Persons.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(sparningsFil, podcastLista);
                }
            }
            catch (Exception ex)
            {
                //Här ska något in senare!! 
            }
        }

        // Här ska en DeSerialiserar-metod skapas!! 



    }
}
