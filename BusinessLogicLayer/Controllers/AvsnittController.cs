using DataAccessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Controllers
{
    internal class AvsnittController
    {

        private readonly IRepository<Avsnitt> _repository;

        public AvsnittController(IRepository<Avsnitt> repository)
        {
            _repository = repository;
        }

        public void AddAvsnitt(Avsnitt newAvsnitt)
        {
            // Valideringar och affärsregler för att lägga till ett avsnitt.
            _repository.Create(newAvsnitt);
        }

        public IEnumerable<Avsnitt> GetAllAvsnitt()
        {
            return _repository.GetAll();
        }

        public void UpdateAvsnitt(int id, Avsnitt updatedAvsnitt)
        {
            // Valideringar och affärsregler för uppdatering.
            _repository.Update(id, updatedAvsnitt);
        }

        public void DeleteAvsnitt(int id)
        {
            _repository.Delete(id);
        }

        // ... fler metoder efter behov ...
        // 
    }
}
