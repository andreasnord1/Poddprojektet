using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;

namespace BusinessLogicLayer.Controllers
{
    public class KategoriController
    {
        IRepository<Kategori> _repository;

        public KategoriController()
        {
            _repository = new KategoriRepository();
        }

        public void AddKategori(string namn)
        {
            // Valideringar och affärsregler för att lägga till en kategori.
            List<Kategori> kategoriLista = GetAllKategorier();
            
            int id = GetNextAvailableID(kategoriLista);

            Kategori nyKategori = new Kategori(id, namn);

            _repository.Create(nyKategori);
        }

        public List<Kategori> GetAllKategorier()
        {
            return _repository.GetAll();
        }

        public void UpdateKategori(int id, Kategori updatedKategori)
        {
            // Valideringar och affärsregler för uppdatering.
            _repository.Update(id, updatedKategori);
        }

        public void DeleteKategori(int id)
        {
            _repository.Delete(id);
        }


        public int GetNextAvailableID(List<Kategori> allaKategorier)
        {
            // Hämtar nästa lediga ID
            if (GetAllKategorier().Count == 0)
            {
                return 1;
            }

            int maxID = allaKategorier.Max(k => k.ID);
            return maxID + 1;
        }

        // ... fler metoder efter behov ...

    }
}
