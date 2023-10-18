using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Tillagd för att kunna använda FileStream.
using System.Xml.Serialization;
using Models;

namespace DataAccessLayer
{
    internal class Serialiserare
    {
        private static readonly string filePath = "Podcasts.xml"; 
        // Centraliserar filnamnet så att man enkelt kan ändra det senare om det behövs.

        public void SerialiseraPodcasts(List<Podcast> podcastLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream sparningsFil = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(sparningsFil, podcastLista);
                }
            }
            catch (Exception ex)
            {
                // Visar ett felmeddelande för användaren, eller kastar om det till en högre nivå.
                throw new Exception("Ett fel uppstod vid serialisering av podcasts.", ex);
            }
        }

        
        public List<Podcast> DeSerialisera()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(fileStream);
                }
            }
            catch (FileNotFoundException) // Första gången programmet körs kanske filen inte finns, så vi returnerar en ny lista.
            {
                return new List<Podcast>();
            }
            catch (Exception ex)
            {
                // Ett oväntat fel inträffade, lägger till mer kontext och kastar om undantaget för ytterligare hantering uppåt.
                throw new Exception("Ett fel uppstod vid deserialisering av podcasts.", ex);
               
            }
        }




    }
}
