using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadatak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true, "bjelogorično");
            Console.WriteLine(stablo1.ToString());


            Stablo stavlo2 = new Stablo(false, "crnogorično");
            Console.WriteLine(stavlo2.ToString());

            Console.ReadKey();
        }
    }

    class Stablo
    {
        bool otpadajuListovi;
        String vrstaStabla;

        public override string ToString()
        {
            string ispis = "Otpadaju listovi: "+ this.getotpadajuListovi() + "\n" +
                "Vrsta Stabla: "+ this.getvrstaStabla() + "\n";
            return ispis;

        }

        public Stablo(bool otpadajuListovi, String vrstaStabla)
        {
            this.otpadajuListovi = otpadajuListovi;
            this.vrstaStabla = vrstaStabla;
        }
       


        public void setotpadajuListovi(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }

        public bool getotpadajuListovi()
        {
            return this.otpadajuListovi;
        }

        public void setvrstaStabla(String vrstaStabla)
        {
            this.vrstaStabla = vrstaStabla;
        }

        public String getvrstaStabla()
        {
            return this.vrstaStabla;
        }
    }

}
