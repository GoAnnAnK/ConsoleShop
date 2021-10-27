using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14_Proj { 

 abstract class Product 
    {
        protected string _name;
        protected int _count;
        protected int _preis;
        private readonly int _id;


        public Product(string name, int count, int preis)
        {
            _name = name;
            _count = count;
            _preis = preis;
        }
        public void DescreeseCount(int count)
        {
            if ((_count - count) >= 0)
            {
                _count -= count;
            }
            else
            {
                Console.WriteLine("Nepakankamas likutis parduotuveje");
            }
        }

        public void IncreeseCount(int count)
        {
            _count += count;
        }
    }

}
