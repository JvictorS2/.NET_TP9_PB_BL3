namespace TP9_PB_.NET.models
{
    public class Turma
    {
        private int codigo;
        private Disciplina disciplina;
        private Professor professor;
        private List<Aluno> alunos;

        public int Codigo { get => codigo; set => codigo = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }
        public Professor Professor { get => professor; set => professor = value; }
        public List<Aluno> Alunos { get => alunos; set => alunos = value; }

        public Turma(int codigo, Disciplina disciplina, Professor professor, List<Aluno> alunos)
        {
            this.codigo = codigo;
            this.disciplina = disciplina;
            this.professor = professor;
            this.alunos = alunos;
        }
        public Turma(int codigo, Disciplina disciplina, Professor professor)
        {
            this.codigo = codigo;
            this.disciplina = disciplina;
            this.professor = professor;
        }

        // métodos
        public string addAluno(Aluno aluno)
        {
            if(abrirTurma() == false)
            {
                return $"Turma cheia, O aluno {aluno.Nome} não pode ser adicionado a turma {this.codigo}";
            }
           
            aluno.addTurma(this);
            alunos.Add(aluno);

            return $"Aluno {aluno.Nome} adicionado a turma {this.codigo}";
        }

        public bool abrirTurma()
        {
            if(alunos.Count >= 10)
            {
                return false;
            }

            return true;
        }

        public string gerarPauta()
        {

            string alunosNaTurma = "";

            for(int i = 0; i < alunos.Count; i++)
            {
                alunosNaTurma += $"{i + 1}° - {alunos[i].Nome}\n";
            }

            return "\n***** Pauta gerada *****\n" +
                $"Disciplina: {Disciplina.Nome}\n" +
                $"Nome Professor: {Professor.Nome}\n"+
                alunosNaTurma;
        }
    }
}
