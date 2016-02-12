using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo henkilo = new Henkilo();
            henkilo.Nimi = "Nickkclass Helmenkalastaja";
            henkilo.Paino = 60;
            Console.WriteLine("henkilön nimi : " + henkilo.Nimi);
            Console.WriteLine("Henkilön paino : " + henkilo.Paino);


            string nimi = "Nikke Kalastaja";
            double paino = 50;

            Henkilo henkilo2 = new Henkilo(nimi, paino);
            Console.WriteLine("henkilön nimi : " + henkilo2.Nimi);
            Console.WriteLine("Henkilön paino : " + henkilo2.Paino);

            Henkilo henkilo3 = new Henkilo { Nimi = "Kapteeni Mustaparta", Paino = 100 };
            Console.WriteLine("henkilön nimi : " + henkilo3.Nimi);
            Console.WriteLine("Henkilön paino : " + henkilo3.Paino);

            Katsoja katsoja = new Katsoja("Ezio Auditore Da Firenze ",100 ,true);
            Console.WriteLine(katsoja.ToString());
            katsoja.huutaa();
        }
    }
}
