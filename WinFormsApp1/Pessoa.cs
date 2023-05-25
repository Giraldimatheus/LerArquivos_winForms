using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        public List<Aluno> alunos { get; set; }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cidade = cidade;
            RG = rg;
            CPF = cpf;
            alunos = new List<Aluno>();
        }
        public override string ToString()
        {
            return Nome; 
        }


    }
}
