﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
     public class Pessoa
    {
		private int anoNascimento;

		public int AnoNascimento
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}
		private string nome;

		public string Nome
		{
			get { return this.nome; }
			set { this.nome = value.ToUpper(); }
		}

		public void ExibirDados()
		{
			Console.WriteLine("Nome:"+ this.nome);
            Console.WriteLine("Ano de Nascimento:" + this.anoNascimento);
			int idade = this.CalcularIdade();
            Console.WriteLine("Idade:"+idade);
			
		}

		private int CalcularIdade()
		{
			DateTime data = DateTime.Now;
			int ano = data.Year;
			int idade = ano - this.anoNascimento;
			return idade;

		}
	}
}
