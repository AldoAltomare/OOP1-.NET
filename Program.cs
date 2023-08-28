using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Dipendente dipendente = new Dipendente();
                dipendente.Nome = "Mario";
                dipendente.Cognome = "Rossi";

                dipendente.GetFullNameProc();

                Studente studente = new Studente();
                studente.Nome = "Aldo";
                studente.Cognome = "Altomare";
                studente.Anni = 31;
                studente.Materia = ".NET";

                studente.CosaStudioProc();

                Animale animale = new Animale();
                animale.Nome = "Silvestro";
                animale.Tipo = "Gatto";
                animale.Razza = "Siamese";
                animale.Anni = 2;
                animale.Zampe = 4;

                animale.GetSound3();

                Animale animale2 = new Animale();
                animale2.Nome = "Silvestro";
                animale2.Tipo = "Coccodrillo";
                animale2.Razza = "Crocodylus acutus";
                animale2.Anni = 3;
                animale2.Zampe = 4;

                animale2.GetSound3();

                Console.ReadLine();


            }
        }
    }
}
