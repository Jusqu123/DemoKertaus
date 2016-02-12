using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKertaus
{
    class Henkilo
    {
        public string Nimi { get; set; }
        private double paino; // 0-100 kapselointi
        public double Paino
        {
            get
            
            {
                return paino;
            }

            set
            {
                if (value >= 0 && value <= 100) paino = value;
                else
                {
                    Console.WriteLine("Henkilön Paino ei ole sallittu");
                 //   paino = 0;
                }
            }


        }
        public Henkilo()
        {
   
        }
        public Henkilo(string nimi, double paino)
        {
            Nimi = nimi;
            Paino = paino;
        }
        public override string ToString()
        {
            return Nimi+"  "+ paino;
        }
    }//class
}//namspace
