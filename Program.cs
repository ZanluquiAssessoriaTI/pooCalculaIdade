using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula idade !");
            Pessoa p = new Pessoa();
            Console.Write ("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write ("Ano de Nascimento:");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();
        }
    }
}
