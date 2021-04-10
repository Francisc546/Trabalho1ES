
using NUnit.Framework;
using NSubstitute;
using FluentAssertions;
using Trabalho1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1Tests
{
    [TestFixture()]
    public class AnimalTests
    {
        private Animal bobby;
        [SetUp]
        public void Setup()
        {
            bobby = new Animal("Bobby", 7, "masculino", "Dalmata", 1);
        }

        [Test()]
        public void Animal_Has_Certain_Name()
        {
            string name = "Bobby";
            var result = bobby.nome;
            result.Should().Be(name);
        } 
        [Test()]
        public void Animal_Is_Of_Certain_Specie()
        {
            string specie = "Dalmata";
            var result = bobby.especie;
            result.Should().Be(specie);
        }
    }
}