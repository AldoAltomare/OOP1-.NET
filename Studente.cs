using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public int Anni { get; set; }

        private string _materia;
        public string Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }

        public string FullName
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }

        public string cosaStudio { get; set; }

        public string CosaStudi
        {
            get
            {
                return "Ciao, ho " + Anni + " anni e studio " + _materia;
            }
        }

        public string CosaStudio()
        {
            return Nome + " " + Cognome;
        }

        public void CosaStudioProc()
        {
            Console.WriteLine("Ciao, ho " + Anni + " anni e studio " + _materia);
        }
    }
}
