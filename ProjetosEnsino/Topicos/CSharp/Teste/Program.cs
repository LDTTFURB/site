using System;
using System.Collections;

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

      Objeto obj1 = new();
      Objeto obj2 = new("Dalton", 55);

      ArrayList lista = new();
      lista.Add(obj1);
      lista.Add(obj2);

      obj1.Escrever();
      obj1.Nome = "Teste";
      obj1.Idade = 20;
      obj1.Escrever();
      obj2.Escrever();

      foreach (var item in lista)
      {
        System.Console.WriteLine(item);
      }


      // Fibonacci f = new Fibonacci();
      // System.Console.WriteLine(f.fibonacci(100));

      ClasseDerivada derivada = new();
      derivada.Valor = 10;
      derivada.MostrarValor();

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