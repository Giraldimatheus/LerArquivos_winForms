using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Aluno : Pessoa
    {
        public Pessoa pessoaAtual;

        public string Matricula { get; set; }
        public string CodigoCurso { get; set; }
        public string NomeCurso { get; set; }

        public Aluno(string matricula, string codigoCurso, string nomeCurso)
            : base("", "", "", "", "")
        {
            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }


        public Aluno(string matricula, string codigoCurso, string nomeCurso, Pessoa pessoaAtual) : this(matricula, codigoCurso, nomeCurso)
        {
            this.pessoaAtual = pessoaAtual;
        }
    }
}
