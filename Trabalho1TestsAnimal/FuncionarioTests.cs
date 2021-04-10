using NUnit.Framework;
using NSubstitute;
using FluentAssertions;
using Trabalho1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute.Exceptions;

namespace Trabalho1.Tests
{
    [TestFixture()]
    public class FuncionarioTests
    {
        private Funcionario maria;

        [SetUp]
        public void Setup()
        {
            maria = new Funcionario("Maria",  "Segunda a Sexta - 9:00 - 15:00");
        }
        [Test()]
        public void Funcionario_Name()
        {
            string name = "Maria";
            var result = maria.nome;
            result.Should().Be(name);
        } 
        [Test()]
        public void Funcionario_Schedule()
        {
            string schedule = "Segunda a Sexta - 9:00 - 15:00";
            var result = maria.disp_hor;
            result.Should().Be(schedule);
        }
    }
}