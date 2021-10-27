using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14_Proj
{
    class Shop : IShop
    {
      //  private readonly List<Product> _products 
        private Candy _candy;
        private Ice _ice;
        private Jelly _jelly;
        private Shoko _shoko;

    public Shop()
        {
            //   _products = new List<Product> { new Candy(1, "Candy)}
            _candy = new Candy("Saldainiai", 2000, 3);
            _ice = new Ice("Ledai", 500, 2 );
            _jelly = new Jelly("Guminukai", 1000, 1);
            _shoko = new Shoko("Sokoladas", 1000, 5);
        }

    public void Bill()
        {
            //tada cia foreach (var products in _products) Metode Buy reikes paduoti product ID ir kieki
         
            Console.WriteLine(_candy.ToString());
            Console.WriteLine(_ice.ToString());
            Console.WriteLine(_jelly.ToString());
            Console.WriteLine(_shoko.ToString());
        }
    public void Buy(int count, string name)
        {
            switch (name)
            {
                case "Saldainiai":
                    _candy.DescreeseCount(count);
                    break;

                case "Ledai":
                    _ice.DescreeseCount(count);
                    break;
                case "Guminukai":
                    _jelly.DescreeseCount(count);
                    break;
                case "Sokoladas":
                    _shoko.DescreeseCount(count);
                    break;
            }
        }
    public void Add(int count, string name )
        {
            switch (name)
            {
                case "Saldainiai":
                    _candy.IncreeseCount(count);
                    break;

                case "Ledai":
                    _ice.IncreeseCount(count);
                    break;
                case "Guminukai":
                    _jelly.IncreeseCount(count);
                    break;
                case "Sokoladas":
                    _shoko.IncreeseCount(count);
                    break;
            }

        }

    }
}
