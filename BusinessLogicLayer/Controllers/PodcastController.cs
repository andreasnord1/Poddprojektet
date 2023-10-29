using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BusinessLogicLayer.Controllers
{
    public class PodcastController
    {


        private readonly IRepository<Podcast> IRepository; // Vårt data repository.

        public PodcastController()
        {
            IRepository = new PodcastRepository();
        }

        public void AddPodcast(Podcast newPodcast)
        {
            if (newPodcast == null)
            {
                throw new ArgumentNullException(nameof(newPodcast), "Podcast kan inte vara null.");
            }

            if (string.IsNullOrEmpty(newPodcast.Url))
            {
                throw new ArgumentException("Podcast måste ha en giltig URL.");
            }

            if (string.IsNullOrEmpty(newPodcast.Titel))
            {
                throw new ArgumentException("Podcast måste ha ett namn.");
            }


            // Kontrollera om en podcast med samma URL redan finns.
            var existingPodcast = IRepository.GetAll().FirstOrDefault(p => p.Url == newPodcast.Url);
            if (existingPodcast != null)
            {
                throw new InvalidOperationException("En podcast med samma URL finns redan.");
            }

            IRepository.Create(newPodcast);
        }

    
        public List<Podcast> GetAllPodcasts()
        {
            return IRepository.GetAll();
        }

        public List<Podcast> GetPodcastsByKategori(Kategori kategori)
        {
            List<Podcast> allaPodcasts = GetAllPodcasts();

            int kategoriID = kategori.ID;

            var podcasts = allaPodcasts.Where(p => p.PodcastKategori.ID == kategoriID);

            List<Podcast> podcastsInomKategorin = podcasts.ToList();

            return podcastsInomKategorin;
        }

        public Avsnitt GetPodcastensSenasteAvsnitt(Podcast valdPodcast)
        {
            Avsnitt senasteAvsnittet = valdPodcast.Avsnitt[0];
            return senasteAvsnittet;
        }



        public Podcast? GetPodcastByUrl(string url)
        {
            return IRepository.GetAll().FirstOrDefault(p => p.Url == url);
        }
        public void UpdatePodcast(int id, Podcast updatedPodcast)
        {
            var existingPodcast = IRepository.GetAll().FirstOrDefault(p => p.ID == id);
            if (existingPodcast == null)
            {
                throw new InvalidOperationException("Podcasten hittades inte.");
            }

            // Validering för att inte tillåta URL att ändras.
            if (existingPodcast.Url != updatedPodcast.Url)
            {
                throw new InvalidOperationException("Det är inte tillåtet att ändra podcastens URL.");
            }

            // Du kan lägga till fler valideringar här om det behövs.

            IRepository.Update(id, updatedPodcast);
        }


        public void UpdatePodcastByUrl(string url, Podcast updatedPodcast)
        {
            var podcastToUpdate = GetPodcastByUrl(url);
            if (podcastToUpdate != null)
            {
                UpdatePodcast(podcastToUpdate.ID, updatedPodcast);
            }
            else
            {
                throw new InvalidOperationException("Ingen podcast med den angivna URL:en hittades.");
            }
        }


        public void DeletePodcast(int id)
        {
            IRepository.Delete(id);
        }

        public void DeletePodcastByUrl(string url)
        {
            var podcastToDelete = GetPodcastByUrl(url);
            if (podcastToDelete != null)
            {
                DeletePodcast(podcastToDelete.ID);
            }
            else
            {
                throw new InvalidOperationException("Ingen podcast med den angivna URL:en hittades.");
            }
        }



        ////public void UpdatePodcastCustomName(int id, string newCustomName)
        ////{
        ////    var existingPodcast = IRepository.GetAll().FirstOrDefault(p => p.ID == id);
        ////    if (existingPodcast == null)
        ////    {
        ////        throw new InvalidOperationException("Podcasten hittades inte.");
        ////    }

        ////    if (string.IsNullOrWhiteSpace(newCustomName))
        ////    {
        ////        throw new ArgumentException("Custom name måste ha ett värde.");
        ////    }

        ////    // Uppdatera det anpassade namnet för podcasten
        ////    existingPodcast.CustomName = newCustomName;

        ////    // Här använder vi Update-metoden från ditt repository för att spara ändringarna
        ////    IRepository.Update(id, existingPodcast);
        ////}


        // ... andra relevanta metoder för affärslogik ...
    }
}

