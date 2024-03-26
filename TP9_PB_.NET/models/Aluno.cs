namespace TP9_PB_.NET.models
{
    public class Aluno
    {
        private int codigo;
        private string nome;
        private List<Turma> turmaList;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Turma> TurmaList { get => turmaList; set => turmaList = value; }

        public Aluno(int Codigo, string Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.turmaList = new List<Turma>();
        }

        public Aluno(int Codigo, string Nome, List<Turma> turmaList)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.turmaList = turmaList;
        }

       // Métodos

        public string addTurma(Turma turma)
        {
           
            turmaList.Add(turma);
            

            return $"Turma {turma.Codigo} teve o aluno {this.nome} adicionado ";
        }

        public string ExibirTurma()
        {
            string turmas = "";

            for(int i =0; i < turmaList.Count; i++)
            {
                turmas += $"{i + 1}° - Tuma: {turmaList[i].Professor.Nome} - {turmaList[i].Disciplina.Nome}\n";
            }

            return $"\n***** Turmas *****\n" +
                    turmas;
                
        }


    }

}