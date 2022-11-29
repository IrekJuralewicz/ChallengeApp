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
            var pr2 = WezPracownika("Tomek");
            Assert.NotSame(pr1, pr2);
            Assert.False(Object.ReferenceEquals(pr1, pr2));
        }

        private Pracownik WezPracownika(string name)
        {
            return new Pracownik(name);

        }


    }
}
