using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Ser.Models
{
    public class Pessoa
    {
        public Pessoa(int Cpf, string nome, int idade)
        {
            CPF = Cpf;

            Nome = nome;

            Idade = idade; 
        }
        public int CPF { get; set; }

        public string Nome { get; set; }    

        public int Idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"A pessoa informada foi {Nome}, do CPF {CPF}, da idade {Idade}");
        }
    }
}