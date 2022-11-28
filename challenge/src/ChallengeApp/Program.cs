using System;
using System.Collections.Generic;
//using System.Linq;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var pracownik = new Pracownik("Irek");
            pracownik.DodajOcenę(0.8);
            pracownik.DodajOcenę(0.2);
            pracownik.DodajOcenę(0.5);
            pracownik.DodajOcenę(0.6);

            var stat = pracownik.PobierzStatystyki();
            //var statshow = 
            //Console.WriteLine($"wynik: {stat:N6}");

            // var pracownik1 = new Pracownik ("Stefan");

            // pracownik1.DodajOcenę(11.2);
            // pracownik1.DodajOcenę(8.01);
            // pracownik1.DodajOcenę(13.111);



            /* 
             var listastring = new List<string>() {"Irek", "Stefan" };
             var listaint = new List<int>() {1,2,3};  

             Console.WriteLine(" ");
             Console.WriteLine("Dzień 5 - Zadanie domowe 1 - zagnieżdżona pętla foreach ");
             Console.WriteLine(" ");
             foreach (var i in listastring)
             {
                 Console.WriteLine(i);
                 foreach (var j in listaint)
                 {
                     Console.WriteLine(j);
                 }

             }
             */
        }
    }


}