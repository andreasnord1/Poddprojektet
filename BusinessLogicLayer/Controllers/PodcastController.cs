using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;

namespace BusinessLogicLayer.Controllers
{
    public class PodcastController
    {


        private readonly IRepository<Podcast> _repository; // Vårt data repository.

        public PodcastController()
        {
            _repository = new PodcastRepository();
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

            if (string.IsNullOrEmpty(newPodcast.PodcastKategori?.Namn))
            {
                throw new ArgumentException("Podcast måste ha en kategori.");
            }

            // Kontrollera om en podcast med samma URL redan finns.
            var existingPodcast = _repository.GetAll().FirstOrDefault(p => p.Url == newPodcast.Url);
            if (existingPodcast != null)
            {
                throw new InvalidOperationException("En podcast med samma URL finns redan.");
            }

            _repository.Create(newPodcast);
        }

        public IEnumerable<Podcast> GetAllPodcasts()
        {
            return _repository.GetAll();
        }

        public Podcast GetPodcastByUrl(string url)
        {
            return _repository.GetAll().FirstOrDefault(p => p.Url == url);
        }
        public void UpdatePodcast(int id, Podcast updatedPodcast)
        {
            var existingPodcast = _repository.GetAll().FirstOrDefault(p => p.id == id);
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

            _repository.Update(id, updatedPodcast);
        }


        public void UpdatePodcastByUrl(string url, Podcast updatedPodcast)
        {
            var podcastToUpdate = GetPodcastByUrl(url);
            if (podcastToUpdate != null)
            {
                UpdatePodcast(podcastToUpdate.id, updatedPodcast);
            }
            else
            {
                throw new InvalidOperationException("Ingen podcast med den angivna URL:en hittades.");
            }
        }


        public void DeletePodcast(int id)
        {
            _repository.Delete(id);
        }

        public void DeletePodcastByUrl(string url)
        {
            var podcastToDelete = GetPodcastByUrl(url);
            if (podcastToDelete != null)
            {
                DeletePodcast(podcastToDelete.Id);
            }
            else
            {
                throw new InvalidOperationException("Ingen podcast med den angivna URL:en hittades.");
            }
        }


        // ... andra relevanta metoder för affärslogik ...
    }
}

