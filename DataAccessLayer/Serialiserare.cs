﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Tillagd för att kunna använda FileStream.
using System.Xml.Serialization;
using Models;

namespace DataAccessLayer
{
    public class Serialiserare
    {
        // Centraliserar filnamnet så att man enkelt kan ändra det senare om det behövs.

        private static readonly string filePathPodcasts = "Podcasts.xml";
        private static readonly string filePathKategorier = "Kategorier.xml";
       


        public void SerialiseraPodcasts(List<Podcast> podcastLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream sparningsFil = new FileStream(filePathPodcasts, FileMode.Create, FileAccess.Write))
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

        public List<Podcast> DeSerialiseraPodcasts()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fileStream = new FileStream(filePathPodcasts, FileMode.Open, FileAccess.Read))
                {
                    object? deserializedObj = xmlSerializer.Deserialize(fileStream);
                    if (deserializedObj is List<Podcast> podcastList)
                    {
                        return podcastList;
                    }
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

            return new List<Podcast>(); // Säkerhetsåterkomst i fall något ovan inte returnerar en lista

        }

        public void SerialiseraKategorier(List<Kategori> kategorier)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream sparningsFil = new FileStream(filePathKategorier, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(sparningsFil, kategorier);
                }
            }
            catch (Exception ex)
            {
                // Visar ett felmeddelande för användaren, eller kastar om det till en högre nivå.
                throw new Exception("Ett fel uppstod vid serialisering av podcasts.", ex);
            }
        }

        public List<Kategori> DeSerialiseraKategorier()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream fileStream = new FileStream(filePathKategorier, FileMode.Open, FileAccess.Read))
                {
                    object? deserializedObj = xmlSerializer.Deserialize(fileStream);
                    if (deserializedObj is List<Kategori> kategoriList)
                    {
                        return kategoriList;
                    }
                }
            }
            catch (FileNotFoundException) // Första gången programmet körs kanske filen inte finns, så vi returnerar en ny lista.
            {
                return new List<Kategori>();
            }
            catch (Exception ex)
            {
                // Ett oväntat fel inträffade, lägger till mer kontext och kastar om undantaget för ytterligare hantering uppåt.
                throw new Exception("Ett fel uppstod vid deserialisering av kategorier.", ex);
            }

            return new List<Kategori>(); // Säkerhetsåterkomst i fall något ovan inte returnerar en lista
        }





    }
}
