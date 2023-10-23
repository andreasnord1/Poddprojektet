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
            podcastLista = new List<Podcast>();
            podcastLista = GetAll();
        }
        public void Create(Podcast entitet)
        {
            podcastLista.Add(entitet);
            SaveChanges();
        }

        public void Delete(int index)
        {
            podcastLista.RemoveAt(index);
            SaveChanges();
        }

        public List<Podcast> GetAll()
        {
            try
            {
                return nySerialiserare.DeSerialiseraPodcasts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveChanges()
        {
            nySerialiserare.SerialiseraPodcasts(podcastLista);
        }

        public void Update(int index, Podcast entitet)
        {
            if (index >= 0)
            {
                podcastLista[index] = entitet;
                SaveChanges();
            }
        }
    }
}
