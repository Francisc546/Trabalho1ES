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
    public class ClienteTests
    {
        private Cliente joao;
        private Servicos serv1;
        [SetUp]
        public void Setup()
        {
            joao = new Cliente("Joao","923123567","Estrada do Castanheiro");
            joao.consulta.Add("consulta de check in");
            serv1 = new Servicos("teste",20.0, 15, "");
            joao.servicos.Add(serv1);
        }

        [Test()]
        public void Client_Has_Certain_Name()
        {
            string name = "Joao";
            var result = joao.nome;
            result.Should().Be(name);
        }
        [Test()]
        public void Client_Is_Of_Certain_Location()
        {
            string location = "Estrada do Castanheiro";
            var result = joao.endereco;
            result.Should().Be(location);
        }

        [Test()]
        public void Client_Services()
        {
            double preco = 20.0;
            var result = joao.servicos[0].preco;
            result.Should().Be(preco);
        }
        [Test()]
        public void Client_Appointments()
        {
            string appointment = "consulta de check in";
            var result = joao.consulta[0];
            result.Should().Be(appointment);
        }

       
    }
}