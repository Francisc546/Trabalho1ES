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
    public class ClinicaTests
    {
        private Servicos serv1;
        private Funcionario func1;
        private Clinica clinica1;
        [SetUp]
        public void Setup()
        {
            serv1 = new Servicos("Desparatizacao",20.0, 15, "Anti-Pulgas");
            func1 = new Funcionario("Pedro", "Segunda a Sexta - 9:00 - 18:00");
            clinica1 = new Clinica();
            clinica1.funcArray.Add(func1);
            clinica1.servArray.Add(serv1);


        }
        [Test()]
        public void Clinica_Service_Medicine()
        {
            string medicine = "Anti-Pulgas";
            var result = clinica1.servArray[0].medicamentos;
            result.Should().Be(medicine);
        }
        [Test()]
        public void Clinica__Name()
        {
            string name = "Pedro";
            var result = clinica1.funcArray[0].nome;
            result.Should().Be(name);
        }

        
    }
}