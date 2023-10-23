using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer.Repositories
{
    public class KategoriRepository : IRepository<Kategori>
    {
        Serialiserare nySerialiserare;
        List<Kategori> kategorier;

        public KategoriRepository()
        {
            nySerialiserare = new Serialiserare();
            kategorier = new List<Kategori>();
            kategorier = GetAll();
        }

        public void Create(Kategori entitet)
        {
            kategorier.Add(entitet);
            SaveChanges();
        }

        public void Delete(int index)
        {
            kategorier.RemoveAt(index);
            SaveChanges();
        }

        public List<Kategori> GetAll()
        {
            try
            {
                return nySerialiserare.DeSerialiseraKategorier();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveChanges()
        {
            nySerialiserare.SerialiseraKategorier(kategorier);
        }

        public void Update(int index, Kategori entitet)
        {
            if (index >= 0)
            {
                kategorier[index] = entitet;
                SaveChanges();
            }
        }


    }
}
