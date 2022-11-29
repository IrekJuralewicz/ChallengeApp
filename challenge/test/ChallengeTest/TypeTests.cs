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
            var pr1 = WezPracownika("Adam");
            //var pr2 = WezPracownika("Tomek");
            var pr2 = pr1; //przypisujemy referencję a nie wartość!!!

            //Assert.NotSame(pr1, pr2);
            //Assert.False(Object.ReferenceEquals(pr1, pr2));
            Assert.Same(pr1, pr2);
            Assert.True(Object.ReferenceEquals(pr1, pr2));
        }

        private Pracownik WezPracownika(string name)
        {
            return new Pracownik(name);

        }


    }
}
