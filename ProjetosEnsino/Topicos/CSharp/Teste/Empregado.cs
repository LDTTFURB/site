namespace Teste
{
    public class Empregado(string nome, short idade)
    {
        // Propriedades
        public string Nome { get; set; } = nome;
        public short Idade { get; set; } = idade;

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