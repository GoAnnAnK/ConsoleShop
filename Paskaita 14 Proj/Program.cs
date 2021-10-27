using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Paskaita_14_Proj
{
    class Program
    {
/*   Sukurti parduotuvę, kuri parduoda saldainius, knygas, puodukus.
Jie visi turi pavadinimą, kiekį. Programa turėtų nepasibaigti įrašius tik vieną komandą,
turėtų leisti kelias.Reikia panaudoti objektinį programavimą.

Galimos komandos konsolėje:
"List" išspausdina informacija, ką galima nusipirkti parduotuvėje, koks kiekis ir kokios kainos.Išpirktų produktų neturėtų rodyti.
"Buy Candy 20" - turėtų nupirkti visus egzistuojančius jeigu toks item egzistuoja parduotuvėje ir yra toks kiekis.Jei ne, turėtų parodyti atitinkamą žinutę.
"Add Cup 30" - turėtų papildyti parduotuvę su atitinkamu produktu ir kiekiu. Tai turętų atsivaizduoti ir "List" komandoje.
Jei tokiu produktų jau yra, papildyti.*/
        static void Main(string[] args)
        {
          
            var shop = new Shop();
            var act = 9;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("----------Sveiki atvyke i paruotuve!!!-----------");
            Console.WriteLine("-------------------------------------------------");
            while (act != 0)
            {

                Console.WriteLine("Ko pageidausyte?: \n 1 - Prekiu sarasas \n 2 - Pirkti \n 3 - Papildyti sarasa \n 4 - Iseiti");
                Console.WriteLine();
                 act = int.Parse(Console.ReadLine());

                switch (act)
                {
                    case 1:
                        shop.Bill();
                        Console.WriteLine() ;
                        break;
                    case 2:
                        // minusuoti prekes is listo . minusuotas prekes priskirti kazkokiam kintamajam, arba sukurti nauja lista - krepseli
                        Console.WriteLine("Ka noretumete pirkti? \n 1 - Saldainiai ; \n 2 - Ledai; \n 3 - Guminukai; \n 4 - Sokoladas \n ");
                        act = int.Parse(Console.ReadLine());
                        switch (act){
                            case 1:
                                Console.WriteLine("Iveskite perkama kieki: \n");
                                var candy = int.Parse(Console.ReadLine());
                                shop.Buy(candy, "Saldainiai");
                                Console.WriteLine($"Jus nupirkote  {candy} vnt saldainiu \n");
                                break;
                            case 2:
                                Console.WriteLine("Iveskite perkama kieki: \n");
                                var ice = int.Parse(Console.ReadLine());
                                shop.Buy(ice, "Ledai");
                                Console.WriteLine($"Jus nupirkote  {ice} vnt ledu \n");
                                break;
                            case 3:
                                Console.WriteLine("Iveskite perkama kieki: \n");
                                var jelly = int.Parse(Console.ReadLine());
                                shop.Buy(jelly, "Guminukai");
                                Console.WriteLine($"Jus nupirkote  {jelly} vnt guminuku \n");
                                break;
                            case 4:
                                Console.WriteLine("Iveskite perkama kieki: \n");
                                var shoko = int.Parse(Console.ReadLine());
                                shop.Buy(shoko, "Sokoladas");
                                Console.WriteLine($"Jus nupirkote  {shoko} vnt sokolado \n");
                                break;
                        }
                        break;
                    case 3:
                        //papildomu prekiu idejimas i krepseli arba esamu padidinimas

                        Console.WriteLine("Koki likuti norite papildyti? \n 1 - Saldainiai ; \n 2 - Ledai; \n 3 - Guminukai; \n 4 - Sokoladas; \n ");
                        act = int.Parse(Console.ReadLine());
                        switch (act)
                        {
                            case 1:
                                Console.WriteLine("Iveskite pildoma kieki:  \n");
                                var candy = int.Parse(Console.ReadLine());
                                shop.Buy(candy, "Saldainiai");
                                Console.WriteLine($"Jus papildete  {candy} vnt saldainiu \n");
                                break;
                            case 2:
                                Console.WriteLine("Iveskite pildoma kieki:  \n");
                                var ice = int.Parse(Console.ReadLine());
                                shop.Buy(ice, "Ledai");
                                Console.WriteLine($"papildete {ice} vnt ledu \n");
                                break;
                            case 3:
                                Console.WriteLine("Iveskite pildoma kieki:  \n");
                                var jelly = int.Parse(Console.ReadLine());
                                shop.Buy(jelly, "Guminukai");
                                Console.WriteLine($"papildete {jelly} vnt guminuku \n");
                                break;
                            case 4:
                                Console.WriteLine("Iveskite pildoma kieki:  \n");
                                var shoko = int.Parse(Console.ReadLine());
                                shop.Buy(shoko, "Sokoladas");
                                Console.WriteLine($"Jus papildete  {shoko} vnt sokolado \n");
                                break;
                        }
                        break;
                    
                    case 4:
                        //Isejimas
                        act = 0;
                        Console.WriteLine(" \n ----------Dekojame uz apsilankima!!! Lauksime sugriztant!!!----------");
                        break;

                }
              
            }

        }
    }
}
