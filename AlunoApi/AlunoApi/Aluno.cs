namespace AlunoApi
{
    public class Aluno
    {
        public int Id { get; set; } 
        public string Nome { get; set; }    

        public String Situacao { get; set; }

        public int Matricula { get; set; }

        public Aluno(int id, string nome, string situacao, int matricula)
        {
            Id = id;
            Nome = nome;
            Situacao = situacao;
            Matricula = matricula;
        }
    }
}
