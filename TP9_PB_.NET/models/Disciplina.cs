namespace TP9_PB_.NET.models
{
    public class Disciplina
    {
        private int codigo;
        private string nome;
   

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }

        public Disciplina(int Codigo, string Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;

        }
        

    }
    
}
