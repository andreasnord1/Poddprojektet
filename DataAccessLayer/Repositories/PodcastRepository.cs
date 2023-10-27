using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer.Repositories
{
    public class PodcastRepository : IRepository<Podcast>
    {
        Serialiserare nySerialiserare;
        List<Podcast> podcastLista;

        public PodcastRepository()
        {
            nySerialiserare = new Serialiserare();
            podcastLista = GetAll();

        }
        public void Create(Podcast entitet)
        {
            podcastLista.Add(entitet);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var podcast = GetById(id);
            if (podcast != null)
            {
                podcastLista.Remove(podcast);
                SaveChanges();
            }
        }


        public List<Podcast> GetAll()
        {          
            
        return nySerialiserare.DeSerialiseraPodcasts();
          
        }

        public Podcast GetById(int id)
        {
            var podcast = podcastLista.FirstOrDefault(p => p.ID == id);
            if (podcast == null)
            {
                throw new Exception("Ingen podcast hittad med det angivna ID:t.");
            }
            return podcast;
        }


        public void SaveChanges()
        {
            nySerialiserare.SerialiseraPodcasts(podcastLista);
        }

        public void Update(int id, Podcast entitet)
        {
            var podcastToUpdate = GetById(id);
            if (podcastToUpdate != null)
            {
                int index = podcastLista.IndexOf(podcastToUpdate);
                podcastLista[index] = entitet;
                SaveChanges();
            }
        }

    }
}
