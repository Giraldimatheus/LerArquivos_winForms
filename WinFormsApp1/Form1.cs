namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<string[]> listaPessoas = new List<string[]>();
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        string nomeArquivo = "Arquivo.dat";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persistencia.lerArquivoParaTela(nomeArquivo, listaPessoas);
            Persistencia.ListBox(listaPessoas, listBoxListaPessoas);
        }

        private void listBox_Processados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persistencia.CriarObjetoPessoa(listaPessoas, listBox_Processados);
        }

        private void button3_Alunos_Click(object sender, EventArgs e)
        {
            Persistencia.CriarObjetoAluno(listaPessoas, listBox_Processados);
        }

    }
}