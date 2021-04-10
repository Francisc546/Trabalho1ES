using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.FileIO;

namespace Trabalho1
{


    public class Animal
    {
        private string _nome;
        private int _idade;
        private string _genero;
        private string _especie;
        private int _id;

        public Animal(string nome, int idade, string genero, string especie, int id)
        {
            this._nome = nome;
            this._idade = idade;
            this._genero = genero;
            this._especie = especie;
            this._id = id;
        }

        public string nome
        {
            get { return _nome; }
        }

        public int idade
        {
            get{return _idade;}
        }
        public string genero {
            get {return _genero ; }
        }
        public string especie {
            get { return _especie; }
        }
        public int id {
            get { return _id; }
        }
        
     
    }

    public class Cliente
    {
        private string _nome;
        private string _contacto;
        private string _endereco;

        public Cliente(string nome, string contacto, string endereco)
        {
            this._nome = nome;
            this._contacto = contacto;
            this._endereco = endereco;
            _consulta = new List<string>();
            _freq = 0;
            _servicos = new List<Servicos>();
        }

        public string nome {
            get { return _nome; }
        }
        public string contacto {
            get { return _contacto; }
        }
        public string endereco {
            get { return _endereco; }
        }

        private List<Servicos> _servicos;

        public List<Servicos> servicos
        {
            get { return _servicos; }
            
        }

        private List<string> _consulta;
        
        public List <string> consulta
        {
            get { return _consulta; }
            
        }


        private int _freq ;
        public int freq
        {
            get { return _freq; }
            set { _freq = value; }
        }


    }

    public class Servicos
    {
        private string _nome;
        private double _preco;
        private double _duracao;
        private string _medicamentos;

        public Servicos(string nome, double preco, double duracao, string medicamentos)
        {
            this._nome = nome;
            this._preco = preco;
            this._duracao = duracao;
            this._medicamentos = medicamentos;
        }

        public string nome
        {
            get { return _nome; }
        }
        public double preco {
            get { return _preco; }
        }
        public double duracao {
            get { return _duracao; }
        }
        public string medicamentos {
            get { return _medicamentos; }
        }
    }


    public class Funcionario
    {
        private string _nome;
        private string _disp_hor;

        public Funcionario(string nome, string disp_hor)
        {
            this._nome = nome;
            this._disp_hor = disp_hor;
            

        }
        public string nome {
            get { return _nome; }
        }

        public string disp_hor {
            get { return _disp_hor; }
        }

    }


    public class Clinica
    {
        private List<Funcionario> _funcArray;

        private List<Servicos> _servArray;
        private List<Cliente> _clientArray;
        private List<Animal> _animalArray;


        public Clinica()
        {

            _funcArray = new List<Funcionario>();
            _servArray = new List<Servicos>();
            _clientArray = new List<Cliente>();
            _animalArray = new List<Animal>();
        }

        public List <Funcionario> funcArray
        {
            get { return _funcArray; }
            
        }
        public List<Servicos> servArray
        {
            get { return _servArray; }
            
        }
        public List<Cliente> clientArray
        {
            get { return _clientArray; }
            
        }

        public List<Animal> animalArray
        {
            get { return _animalArray; }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal cao = new Animal("boby", 20, "male", "dad", 1);
            Cliente joao = new Cliente("Joao", "923123412", "estrada do quintal");
            Servicos serv1 = new Servicos("Vacinacao",10.0 , 8,"10 ml anti-raiva");
            Servicos serv2 = new Servicos("Desparatisacao",20.5, 5, "Anti-Pulgas");
            Servicos serv3 = new Servicos("Introducao do chip",30.0, 4, "Chip");
            Servicos serv4 = new Servicos("Cirurgia",50.0, 40, "anestesia volatil");
            Clinica clinica = new Clinica();
            clinica.servArray.Add(serv1);
            clinica.servArray.Add(serv2);
            clinica.servArray.Add(serv3);
            clinica.servArray.Add(serv4);
            Funcionario pedro = new Funcionario("Pedro", "Segunda a Sexta 9:00 - 17:00");
            adicionaFuncionario(pedro,clinica);
            adicionaCliente(joao,clinica);
            adicionaAnimal(cao, clinica);

            bool menu = true;

            do
            {
                Console.WriteLine(" 1 - Servicos prestados pela clinica ");
                Console.WriteLine(" 2 - Profissionais de Saude e disponibilidade horaria");
                Console.WriteLine(" 3 - Gerir relatorio para o cliente");
                Console.WriteLine(" 4 - Adicionar novo cliente");
                Console.WriteLine(" 5 - Adicionar consultas, frequencia e servicos a um cliente");
                Console.WriteLine(" 6 - Criar novo animal");
                Console.WriteLine(" 7 - Criar novo funcionario");
                Console.WriteLine(" 8 - Listar animais da clinica");
                Console.WriteLine(" 9 - Adicionar servicos");
                Console.WriteLine(" 10 - Sair da aplicacao");
                
                int o;
                int i = 2;
                while(!int.TryParse(Console.ReadLine(), out o))
                {
                    Console.WriteLine("Escreva o número da opção que quer selecionar");
                }

                switch (o)
                {
                    case 1:
                        ServicosDisponiveis(clinica);
                        break;
                    case 2:
                        DisponibilidadeFuncionarios(clinica);
                        break;
                    case 3:
                        Console.WriteLine("Escreva o nº do Cliente que pretende gerir o relatório");
                        for (int j = 0; j < clinica.clientArray.Count ; j++)
                        {
                            Console.WriteLine(" Cliente nº " + j + "  - " + clinica.clientArray[j].nome);
                        }

                        int selrel;
                        int.TryParse(Console.ReadLine(), out selrel);
                        GereRelatorio(clinica.clientArray[selrel]);

                        break;
                    case 4:
                        Console.WriteLine("Escreva o nome do Cliente");
                        string nomec = Console.ReadLine();
                        Console.WriteLine("Escreva o contacto do Cliente");
                        string contacto = Console.ReadLine();
                        Console.WriteLine("Escreva o endereco do Cliente");
                        string endereco = Console.ReadLine();
                        criaCliente(nomec,contacto,endereco,clinica);
                        break;
                    case 5:
                        Console.WriteLine("Escreva o nº do Cliente que pretende adicionar consultas, frequencia e servicos");
                        for (int j = 0; j < clinica.clientArray.Count ; j++)
                        {
                            Console.WriteLine(" Cliente nº " + j + "  - " + clinica.clientArray[j].nome);
                        }

                        int sel;
                        int.TryParse(Console.ReadLine(), out sel);
                        Console.WriteLine("Escreva a consulta do Cliente");
                        string consulta = Console.ReadLine();
                        Console.WriteLine("Escreva a frequência do Cliente");
                        int freq;
                        int.TryParse(Console.ReadLine(), out freq);
                        Console.WriteLine("Escreva o nº do servico que pretende adicionar ao Cliente");
                        ServicosDisponiveis(clinica);
                        int cons;
                        int.TryParse(Console.ReadLine(), out cons);
                        adicionaConsultaCliente(clinica.clientArray[sel], consulta,freq,clinica.servArray[cons]);
                        break;
                    case 6:
                        Console.WriteLine("Escreva o nome do Animal");
                        string nomea = Console.ReadLine();
                        Console.WriteLine("Escreva a idade do Animal");
                        int idade;
                        int.TryParse(Console.ReadLine(), out idade); 
                        Console.WriteLine("Escreva o genero do Animal");
                        string genero = Console.ReadLine();
                        Console.WriteLine("Escreva a especie do Animal");
                        string especie = Console.ReadLine();
                        criaAnimal(nomea, idade, genero, especie, i, clinica);
                        i++;
                        break;
                    case 7:
                        Console.WriteLine("Escreva o nome do Funcionario");
                        string nomef = Console.ReadLine();
                        Console.WriteLine("Escreva a disponibilidade do Funcionario");
                        string disp = Console.ReadLine();
                        criaFuncionario(nomef,disp,clinica);
                        break;
                    case 8:
                        for (int j = 0; j < clinica.animalArray.Count; j++)
                        {
                            Console.WriteLine("Animal nº " + j + " :");
                            Console.WriteLine("Nome : " + clinica.animalArray[j].nome);
                            Console.WriteLine("Idade : " + clinica.animalArray[j].idade);
                            Console.WriteLine("Genero : " + clinica.animalArray[j].genero);
                            Console.WriteLine("Especie : " + clinica.animalArray[j].especie);
                            Console.WriteLine("ID : " + clinica.animalArray[j].id);
                        }
                        break;
                    case 9:
                        Console.WriteLine("Escreva o nome do servico");
                        string nomes = Console.ReadLine();
                        Console.WriteLine("Escreva o preco do servico");
                        double preco;
                        double.TryParse(Console.ReadLine(), out preco);
                        Console.WriteLine("Escreva a duracao do servico");
                        double duracao;
                        double.TryParse(Console.ReadLine(), out duracao);
                        Console.WriteLine("Escreva os medicamentos");
                        string medicamentos = Console.ReadLine();
                        adicionarServicos(clinica,nomes,preco,duracao,medicamentos);
                        break;
                    case 10:
                        menu = false;
                        break;
                }

            } while (menu);


        }

        public static void GereRelatorio(Cliente c) //Função responsável por gerir relatórios de um dado cliente
        {
            
            Console.WriteLine("Nome do Cliente : "+c.nome);
            Console.WriteLine("Consultas: ");
            for (int i = 0; i < c.consulta.Count ; i++)
            {
                Console.WriteLine("nº " +i + ": ");
                Console.WriteLine(c.consulta[i]);
            }
            Console.WriteLine("Frequência: ");
            Console.WriteLine(c.freq);
            Console.WriteLine("Servicos: ");
            for (int i = 0; i < c.servicos.Count ; i++)
            {
                Console.WriteLine("nº " + i + ": ");
                Console.WriteLine("Nome: " + c.servicos[i].nome);
                Console.WriteLine("Preco: " + c.servicos[i].preco + " Euros");
                Console.WriteLine("Duracao: " + c.servicos[i].duracao + " minutos");
                Console.WriteLine("Medicamentos: " + c.servicos[i].medicamentos);
                Console.WriteLine(" ");
            }

        }

        public static void ServicosDisponiveis(Clinica c) //Função responsável por mostrar todos os serviços disponíveis
        {
            for (int i = 0; i < c.servArray.Count ; i++)
            {
                Console.WriteLine("Servico nº " +i );
                Console.WriteLine("Nome: "+c.servArray[i].nome);
                Console.WriteLine("Preco: "+ c.servArray[i].preco + " Euros");
                Console.WriteLine("Duracao: " + c.servArray[i].duracao + " minutos");
                Console.WriteLine("Medicamentos: "+ c.servArray[i].medicamentos);
                Console.WriteLine("");
            }
        }

        public static void DisponibilidadeFuncionarios(Clinica c) //Função responsável por mostrar o nome e a disponibilidade dos funcionários da clínica
        {
            for (int i = 0; i < c.funcArray.Count ; i++)
            {
                Console.WriteLine("Funcionario: "+ c.funcArray[i].nome);
                Console.WriteLine("Disponibilidade de horario: "+ c.funcArray[i].disp_hor);
                Console.WriteLine("");
            }
        }

        public static void criaFuncionario(string n, string disp, Clinica c)//Função que trata da criação de novas instância da classe Funcionario
        {
            Funcionario f = new Funcionario(n, disp);
            adicionaFuncionario(f,c);
        }

        public static void adicionaFuncionario(Funcionario f, Clinica c)//Função que adiciona o funcionário à lista da clínica
        {
            c.funcArray.Add(f);
        }


        public static void criaCliente(string nome, string contacto, string endereco, Clinica c)//Função que trata da criação de novas instância da classe Cliente
        {
            Cliente cliente = new Cliente(nome, contacto, endereco);
            adicionaCliente(cliente,c);
        }

        public static void adicionaCliente(Cliente cliente, Clinica c)//Função que adiciona o cliente à lista da clínica
        {
            c.clientArray.Add(cliente);
        }

        public static void criaAnimal(string nome, int idade, string genero, string especie, int id, Clinica c)//Função que trata da criação de novas instância da classe Animal
        {
            Animal a = new Animal(nome, idade, genero, especie, id);
            adicionaAnimal(a,c);
        }

        public static void adicionaAnimal(Animal animal, Clinica c)//Função que adiciona o animal à lista da clínica
        {
            c.animalArray.Add(animal);
        }

        public static void adicionaConsultaCliente(Cliente c, string consulta, int freq, Servicos serv) //Função que adiciona os dados da consulta, frequência e o serviço ao cliente
        {
            c.consulta.Add(consulta);
            c.freq = freq;
            c.servicos.Add(serv);
        }

        public static void adicionarServicos(Clinica c, string nome, double preco, double duracao, string medicamentos )
        {
            Servicos s = new Servicos(nome, preco, duracao, medicamentos);
            c.servArray.Add(s);
        }
        
    }
}
