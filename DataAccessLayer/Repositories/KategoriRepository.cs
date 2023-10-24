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

        public void Delete(int id)
        {
            // Hitta kategorin med det givna ID:t.
            var kategoriToRemove = kategorier.FirstOrDefault(kat => kat.ID == id);

            // Om kategorin finns, ta bort den från listan och spara ändringarna.
            if (kategoriToRemove != null)
            {
                kategorier.Remove(kategoriToRemove);
                SaveChanges();

            }
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

        public void Update(int id, Kategori entitet)
        {
            int index = kategorier.FindIndex(Kat => Kat.ID == entitet.ID);

            if (index >= 0)
            {
                kategorier[index] = entitet;
                SaveChanges();

            }
        }

        public Kategori GetById(int id)
        {
            // Använder LINQ för att hitta den första kategorin med det givna ID:t eller returnerar null om ingen sådan kategori finns.
            return kategorier.FirstOrDefault(kat => kat.ID == id);
        }



    }
}
