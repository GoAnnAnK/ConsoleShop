using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14_Proj
{
     class Candy : Product 
    {
        public Candy (string name, int count, int preis) : base(name, count, preis)
        {
            
        }
        
        public override string ToString()
        {
            return  $" Prekes pavadinimas: {_name}, Turimas kiekis: {_count}, Kaina: {_preis}" ;
        }

   

    }
}
