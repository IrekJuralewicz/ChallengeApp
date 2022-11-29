using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class Pracownik
    {
        //private string name;
        

        private List<double> noty = new List<double>();

        public Pracownik(string name)
        {
            this.Name = name;
        }

        public string Name { get ;}
            

        // public string Name
        // {
        //     get
        //     {
        //         return this.name;
        //     }
        // }

        public void DodajOcenę(double ocena)
        {
            this.noty.Add(ocena);
        }

        public Statystyki PobierzStatystyki()
        {
            var wynik = new Statystyki();
            wynik.Srednia = 0.0;
            wynik.Najwyzsza = double.MinValue;
            wynik.Najnizsza = double.MaxValue;
            foreach (var ocena in noty)
            {
                wynik.Najnizsza = Math.Min(ocena, wynik.Najnizsza);
                wynik.Najwyzsza = Math.Max(ocena, wynik.Najwyzsza);
                wynik.Srednia += ocena;
            }
            wynik.Srednia /= noty.Count;

            Console.WriteLine($"Pracownik: {Name}");
            Console.WriteLine($"Ocena najniższa is: {wynik.Najnizsza:N6}");
            Console.WriteLine($"Ocena najwyższa is: {wynik.Najwyzsza:N6}");
            Console.WriteLine($"The średnia is: {wynik.Srednia:N6}");
            return wynik;
        }

        /*public Statystyki PokazStatystyki()
        {
            // var wynik = 0.0;
            // var najwyzszaOcena = double.MinValue; //przypisujemy minimalną dla początkowego porównania
            // var najnizszaOcena = double.MaxValue; //analogicznie jak wyżej

            // foreach (var n in this.noty)
            // {
            //     najnizszaOcena = Math.Min(najnizszaOcena, n);
            //     najwyzszaOcena = Math.Max(najwyzszaOcena, n);

            //     wynik += n;
            // }

            // wynik /= noty.Count;
            // var test = wynik.
            // Console.WriteLine($"Pracownik: {name}");
            // Console.WriteLine($"Ocena najniższa is: {wynik.:N6}");
            // Console.WriteLine($"Ocena najwyższa is: {najwyzszaOcena:N6}");
            // Console.WriteLine($"The średnia is: {wynik:N6}");
        }
        
        */


    }
}
