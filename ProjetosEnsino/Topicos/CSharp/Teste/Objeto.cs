namespace Teste
{
    public class Objeto(string nome, short idade) : IObjeto
    {
        // Propriedades
        public string Nome { get; set; } = nome;
        public short Idade { get; set; } = idade;

        // Construtor padrão
        public Objeto() : this("", 0)
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