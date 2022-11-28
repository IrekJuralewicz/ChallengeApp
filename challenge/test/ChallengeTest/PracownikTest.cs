using System;
using ChallengeApp;
using Xunit;

namespace ChallengeTest
{
    public class PracownikTest
    {
        [Fact]
        public void Test1()
        {
            //arrange         
            var prac = new Pracownik("Test1");
            prac.DodajOcenę(0.5);
            prac.DodajOcenę(0.9);
            prac.DodajOcenę(1.9);
            prac.DodajOcenę(2.8);
            
            //act
            var wynik = prac.PobierzStatystyki();
            //assert            
            Assert.Equal(1.5, wynik.Srednia,1);          
            Assert.Equal(0.5,wynik.Najnizsza);
            Assert.Equal(2.8,wynik.Najwyzsza);
        }

        [Fact]
        public void Test2()
        {
            // arrange            
            var prac2 = new Pracownik("Test2");
            prac2.DodajOcenę(1.1111);
            prac2.DodajOcenę(2.2222);
            prac2.DodajOcenę(0.22);
            prac2.DodajOcenę(3.11);
            // act            
            var wynik = prac2.PobierzStatystyki();
            // assert
            Assert.Equal(1.6658, wynik.Srednia,4);
            Assert.Equal(0.22, wynik.Najnizsza);
            Assert.Equal(3.11, wynik.Najwyzsza);
        }

        [Fact]
        public void Test3()
        {
            // arrange            
            var prac = new Pracownik("Test3");
            prac.DodajOcenę(10.1111);
            prac.DodajOcenę(20.2222);
            prac.DodajOcenę(4.22);
            prac.DodajOcenę(7.11);
            // act            
            var wynik = prac.PobierzStatystyki();
            // assert
            Assert.Equal(1.6658, wynik.Srednia,4);
            Assert.Equal(0.22, wynik.Najnizsza);
            Assert.Equal(3.11, wynik.Najwyzsza);
        }        
    }
}
