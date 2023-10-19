using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;

namespace BusinessLogicLayer.Controllers
{
    internal class PodcastController
    {
        private readonly IRepository<Podcast> _repository; // Vårt data repository.

        public PodcastController()
        {
            _repository = new PodcastRepository();
        }

        public void AddPodcast(Podcast newPodcast)
        {
            // Här kan vi lägga till valideringar eller affärsregler.
            // Till exempel, kolla om podcasten redan finns innan vi lägger till den.

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

