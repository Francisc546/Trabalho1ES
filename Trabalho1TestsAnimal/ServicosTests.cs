using NUnit.Framework;
using NSubstitute;
using FluentAssertions;
using Trabalho1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1.Tests
{
    [TestFixture()]
    public class ServicosTests
    {
        private Servicos serv1;

        [SetUp]
        public void Setup()
        {
            serv1 = new Servicos("Teste",20.0, 15, "");
        }

        [Test()]
        public void Servicos_Price()
        {
            double price = 20.0;
            var result = serv1.preco;
            result.Should().Be(price);
        }  
        [Test()]
        public void Servicos_Duration()
        {
            double duration = 15;
            var result = serv1.duracao;
            result.Should().Be(duration);
        }
    }
}