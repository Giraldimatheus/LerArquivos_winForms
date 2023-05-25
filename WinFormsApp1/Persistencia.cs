using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Persistencia
    {
        static List<Pessoa> listaPessoas = new List<Pessoa>();
        static List<Aluno> listaAlunos = new List<Aluno>();


        public static void ListBox(List<string[]> lista, ListBox listBox)
        {
            foreach (var item in lista)
            {
                string linha = string.Join(" ", item);
                listBox.Items.Add(linha);
            }
        }

        public static void lerArquivoParaTela(string nomeArquivo, List<string[]> listaPessoas)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetor;
                string linha;

                do
                {
                    linha = leitor.ReadLine();
                    vetor = linha.Split('-');
                    if (vetor[0] != "X")
                    {
                        listaPessoas.Add(vetor);
                    }
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch
            {
                Console.WriteLine("Problemas com arquivo.");
            }
        }

        public static void CriarObjetoPessoa(List<string[]> lista, ListBox listBox)
        {
            listBox.Items.Clear();
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();
            Pessoa? pessoaAtual = null;

            for (int i = 0; i < lista.Count; i++)
            {
                string[] linhaAtual = lista[i];
                if (linhaAtual[0] == "Z")
                {
                    pessoaAtual = new Pessoa(linhaAtual[1], linhaAtual[2], linhaAtual[3], linhaAtual[4], linhaAtual[5]);
                    pessoas.Add(pessoaAtual);
                    listBox.Items.Add($"Pessoa: {pessoaAtual.Nome}");
                }

            }
            listBox.Items.Add("-------------------------Total Pessoas-------------------------------");

            listBox.Items.Add($"Total de Pessoas criados: {pessoas.Count}");

        }

        public static void CriarObjetoAluno(List<string[]> lista, ListBox listBox)
        {
            listBox.Items.Clear();
            List<Aluno> alunos = new List<Aluno>();


            for (int i = 0; i < lista.Count; i++)
            {
                string[] linhaAtual = lista[i];
                string[] proxLinha = new string[] { };
                if (i + 1 < lista.Count)
                {
                    proxLinha = lista[i + 1];

                    if (linhaAtual[0].StartsWith("Z") && proxLinha[0].StartsWith("Y"))
                    {

                        var pessoa = new Pessoa(linhaAtual[1], linhaAtual[2], linhaAtual[3], linhaAtual[4], linhaAtual[5]);
                        Aluno aluno = new Aluno(proxLinha[1], proxLinha[2], proxLinha[3], pessoa);
                        alunos.Add(aluno);
                        listBox.Items.Add($"Aluno: {aluno.pessoaAtual.Nome} - Curso: {aluno.NomeCurso}");
                    }
                }


            }
            listBox.Items.Add("-------------------------Total Alunos-------------------------------");
            listBox.Items.Add($"Total de Alunos criados: {alunos.Count}");

            
        }

    }
}
