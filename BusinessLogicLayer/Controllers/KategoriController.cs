using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;

namespace BusinessLogicLayer.Controllers
{
    internal class KategoriController
    {
        private readonly IRepository<Kategori> _repository;

        public KategoriController()
        {
            _repository = new KategoriRepository();
        }

        public void AddKategori(int id, string namn)
        {
            // Valideringar och affärsregler för att lägga till en kategori.

            Kategori nyKategori = new Kategori(id, namn);

            _repository.Create(nyKategori);
        }

        public IEnumerable<Kategori> GetAllKategorier()
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

        // ... fler metoder efter behov ...

    }
}
