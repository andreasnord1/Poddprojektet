#nullable enable

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

        private const int INITIAL_ID = 1;


        IRepository<Kategori> _repository;

        public KategoriController(IRepository<Kategori> repository)
        {
            _repository = repository;
        }

        public void AddKategori(string namn)

        {
         
            // Strängvalidering

            if (string.IsNullOrEmpty(namn))
            {
                throw new ArgumentException("Kategori namn kan inte vara tomt eller null.");
            }

            // Validerar unikheten hos kategorinamn

            List<Kategori> kategoriLista = GetAllKategorier();
            if (kategoriLista.Any(k => k.Namn.Equals(namn, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("En kategori med detta namn finns redan.");
            }

            int id = GetNextAvailableID(kategoriLista);

            Kategori nyKategori = new Kategori(id, namn);

            _repository.Create(nyKategori);
        }

        public List<Kategori> GetAllKategorier()
        {
            return _repository.GetAll();
        }

        public Kategori GetKategoriById(int id)
        {
            return _repository.GetById(id); // Återger en Kategori-entitet baserad på ID
        }

        public void UpdateKategori(int id, Kategori updatedKategori)
        {

            // Kontrollera att kategorin med det angivna ID:t finns
            var existingKategori = _repository.GetById(id); // Ska lägga till en sån metod i repository
            if (existingKategori == null)
            {
                throw new InvalidOperationException($"Kategori med ID {id} finns inte.");
            }

            // Se till att det inte finns någon annan kategori med samma namn (utom den som uppdateras)
            if (GetAllKategorier().Any(k => k.Namn.Equals(updatedKategori.Namn, StringComparison.OrdinalIgnoreCase) && k.ID != id))
            {
                throw new InvalidOperationException("En kategori med detta namn finns redan.");
            }

            _repository.Update(id, updatedKategori);
        }

        public void DeleteKategori(int id)
        {
            // Kontrollera att kategorin med det angivna ID:t finns
            var existingKategori = _repository.GetById(id); // Ska lägga till en sån metod i repository
            if (existingKategori == null)
            {
                throw new InvalidOperationException($"Kategori med ID {id} finns inte.");
            }

            _repository.Delete(id);
        }


        public int GetNextAvailableID(List<Kategori> allaKategorier)
        {
            // Hämtar nästa lediga ID
            if (allaKategorier.Count == 0)
            {
                return INITIAL_ID;
            }

            // Om listan inte är tom, hämtar vi det högsta ID:t och lägger till 1

            int maxID = allaKategorier.Max(k => k.ID);
            return maxID + 1;
        }



        // ... fler metoder efter behov ...


    }

}


#nullable disable