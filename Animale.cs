using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animale
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Razza { get; set; }
        public int Anni { get; set; }
        public int Zampe { get; set; }
        public int Test { get; set; }

        public string GetSound()
        {
            if (Tipo == "Cane")
            {
                return ("Bau");
            }else if (Tipo == "Gatto")
            {
                return ("Miao");
            }
            else
            {
                return ("...In realtà non so che verso faccio");
            }
        }

        public void GetSound3()
        {
            Console.WriteLine("Sono un " + Tipo + " e faccio " + GetSound());
        }

    }
}
