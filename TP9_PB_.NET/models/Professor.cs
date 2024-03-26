
namespace TP9_PB_.NET.models
{
    public class Professor
    {
        private int matricula;
        private string nome;
   

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
      

        public Professor(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;

        }
    }

}