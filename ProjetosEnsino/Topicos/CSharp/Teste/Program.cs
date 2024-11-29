using System;

namespace Teste
{
  class Program
  {
    private Program()
    {
      bool teste = true;
      teste = !teste;

      int divNumero = 10;
      divNumero <<= 1;
      divNumero >>= 1;
      divNumero >>= 1;
      divNumero >>= 1;

      int numero = 5; // Em binário: 0000 0101
      int complemento = ~numero; // Inverte os bits

      Console.WriteLine($"Número original: {numero}");
      Console.WriteLine($"Complemento bit a bit: {complemento}");
      Console.WriteLine($"Representação binária do numero: {Convert.ToString(numero, 2).PadLeft(32, '0')}");
      Console.WriteLine($"Representação binária do compl.: {Convert.ToString(complemento, 2).PadLeft(32, '0')}");

      int valor = 5;
      TestePassagemParametro(ref valor);
      System.Console.WriteLine(valor);

      Empregado emp1 = new();
      Empregado emp2 = new("Dalton", 55);

      emp1.Escrever();
      emp1.Nome = "Teste";
      emp1.Idade = 20;
      emp1.Escrever();
      emp2.Escrever();

    }

    private static void TestePassagemParametro(ref int valor)
    {
      valor = 10;
    }

    static void Main()
    {
      _ = new Program();
    }

  }
}