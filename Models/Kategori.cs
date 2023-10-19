using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    
    public class Kategori
    {

        public Kategori(int id, string namn) 
        {
            Id = id; //Endast exempel tillsvidare
            Namn = namn;
        }
        public int Id { get; set; }
        public string Namn { get; set; }
        // Andra relevanta egenskaper...

    }
}
