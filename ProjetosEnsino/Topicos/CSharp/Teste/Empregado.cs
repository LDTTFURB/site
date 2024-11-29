namespace Teste
{
  public class Empregado(string nome, short idade)
  {
    public Empregado() : this("", 0)
    {

    }

    public void Escrever()
    {
      System.Console.WriteLine(nome);
      System.Console.WriteLine(idade);
    }

  }
}