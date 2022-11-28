using System;
using ChallengeApp;
using Xunit;

namespace ChallengeTest
{
    public class TypeTests
    {
        [Fact]
        public void WezPracownikaZwracaRozneObiekty()
        {
          var pr1 =  WezPracownika("Adam");
          var pr2 =  WezPracownika("Tomek");
          
          Assert.Equal("Adam", pr1.Name);
          Assert.Equal("Tomek", pr2.Name);
        }

        private Pracownik WezPracownika (string name)
        {
            return new Pracownik(name);

        }
       
       
    }
}
