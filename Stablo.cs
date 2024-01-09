using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
 
namespace Vježba3

{

    /*Definirajte klasu Stablo sa sljedećim članicama:

    varijabla tipa bool otpadajuListovi

    varijabla tipa string vrstaStabla

    svojstvo OtpadajuListovi (get() i set())

    konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli otpadajuListovi

    override metode ToString()

    Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost false. 

    Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite vrijednost true.

    Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je vrijednost varijable otpadajuListovi true, 

    vrijednost varijable vrstaStabla je bijelogorično, a ukoliko je vrijednost varijable otpadajuListovi false, 

    vrijednost varijable vrstaStabla je crnogorično.

     */

    class Stablo

    {

        bool otpadajulistovi;

        string vrstaStabla;

        public bool Otpadajulistovi { get => otpadajulistovi; set => otpadajulistovi = value; }

        public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }

        public Stablo() { }

        public Stablo(bool otpadajulistovi)

        {

            this.otpadajulistovi = otpadajulistovi;

        }

        public override string ToString()

        {

            string ispis = "Ovo stablo je:";

            if (otpadajulistovi)

            {

                ispis += "listopadno.";

            }

            else

            {

                ispis += "Zimzeleno.";

            }

            return ispis;

        }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            Stablo stablo1 = new Stablo();

            Stablo stablo2 = new Stablo();

            Console.WriteLine(stablo1.ToString());

            Console.WriteLine(stablo2.ToString());




            Console.ReadKey();


        }

    }

}
