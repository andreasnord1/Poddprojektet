#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        public KategoriLista LoadCategoryList()
        {
            var kategoriLista = new KategoriLista { Categories = new List<string>() };

            foreach (var kategori in GetAll())
            {
                kategoriLista.Categories.Add(kategori.Namn); 
            }

            return kategoriLista;
        }

        public void SaveCategoryList(KategoriLista kategoriLista)
        {
            // Konvertera från KategoriLista till List<Kategori> och spara
            kategorier.Clear();
            foreach (var kategoriNamn in kategoriLista.Categories)
            {
                kategorier.Add(new Kategori { Namn = kategoriNamn }); 
            }
            SaveChanges();
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
            var podcast = kategorier.FirstOrDefault(p => p.ID == id);
            if (podcast == null)
            {
                throw new Exception("Ingen podcast hittad med det angivna ID:t.");
            }
            return podcast;
        }

       
    }


#nullable disable
}
