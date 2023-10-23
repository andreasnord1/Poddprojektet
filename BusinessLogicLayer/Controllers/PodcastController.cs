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

        public void UpdatePodcast(int id, Podcast updatedPodcast)
        {
            // Lägg till valideringar och affärsregler här.
            _repository.Update(id, updatedPodcast);
        }

        public void DeletePodcast(int id)
        {
            _repository.Delete(id);
        }

        // ... andra relevanta metoder för affärslogik ...
    }
}

