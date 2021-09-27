using System;
using System.Collections.Generic;

namespace EDD_27_09_struct
{
    public struct dados 
    {
        public string Nome;
        public string DDD;
        public string Telefone;
        public string Email;
        public string NomMae;
        public string NomPai;
        public string Endereco;
        public string Observ;
        
    }
    class Program
    {
        static int Menu()
        {
            Console.WriteLine($"\ndigite 1 para cadastrar" +
                "\ndigite 2 para listar" +
                "\ndigite 3 para procurar" +
                "\ndigite 4 para finalizar");
            return int.Parse(Console.ReadLine());
        }
        static dados Cadastrar(int quant)
        {
            dados entrada = new dados();
            Console.WriteLine($"Cadastro da pessoa nº{quant}");
            Console.WriteLine("Nome: ");
            entrada.Nome = Console.ReadLine();
            Console.WriteLine("DDD: ");
            entrada.DDD = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            entrada.Telefone = Console.ReadLine();
            Console.WriteLine("Email: ");
            entrada.Email = Console.ReadLine();
            Console.WriteLine("Nome mae: ");
            entrada.NomMae = Console.ReadLine();
            Console.WriteLine("Nome pai: ");
            entrada.NomPai = Console.ReadLine();
            Console.WriteLine("Endereco: ");
            entrada.Endereco = Console.ReadLine();
            Console.WriteLine("Observação: ");
            entrada.Observ = Console.ReadLine();

            return entrada;
        }

        static void Main(string[] args)
        {
            int opcao = 5;
            dados entrada;
            List<dados> Listinha = new List<dados>();
            do
            {
                switch (opcao)
                {
                    case 1:
                        {
                            Listinha.Add(Cadastrar(Listinha.Count+1));
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine($"Um total de {Listinha.Count} pessoas foram armazenadas");
                            foreach (dados d in Listinha)
                            {
                                Console.WriteLine($"|| Nome: {d.Nome}|| Telefone: ({d.DDD}){d.Telefone}|| Email: {d.Email}|| Mãe: {d.NomMae}|| Pai: {d.NomPai}|| Endereco: {d.Endereco}; {d.Observ}||");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Digite o nome que deseja procurar");
                            string procurar = Console.ReadLine();
                            foreach(dados d in Listinha)
                            {
                                if(d.Nome == procurar)
                                {
                                    Console.WriteLine($"|| Nome: {d.Nome}|| Telefone: ({d.DDD}){d.Telefone}|| Email: {d.Email}|| Mãe: {d.NomMae}|| Pai: {d.NomPai}|| Endereco: {d.Endereco}; {d.Observ}||");
                                } 
                            }
                        }
                        break;
                    
                    default:
                        break;
                }
                opcao = Menu();

            } while (opcao != 4);
            Console.WriteLine("finalizado");
        }
    }
}
