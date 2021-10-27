using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14_Proj
{
    interface IShop
    {
        void Bill();
        void Buy(int count, string name);
        void Add(int count, string name);


    //  void PriceList();

     

    }
}
