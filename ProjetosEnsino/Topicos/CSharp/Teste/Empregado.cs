namespace Teste
{
    public class Empregado
    {
        // Propriedades
        public string Nome { get; set; }
        public short Idade { get; set; }

        // Construtor com parâmetros
        public Empregado(string nome, short idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Construtor padrão
        public Empregado() : this("", 0)
        {
        }

        // Método para escrever informações do empregado
        public void Escrever()
        {
            System.Console.WriteLine(Nome);
            System.Console.WriteLine(Idade);
        }
    }
}