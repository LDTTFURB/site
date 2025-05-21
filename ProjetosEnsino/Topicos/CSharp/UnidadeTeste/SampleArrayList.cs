using System;
using System.Collections;

class SampleArrayList
{
    static void Main()
    {
      Pessoa pessoa = new Pessoa();
      pessoa.setNome("João");
      pessoa.setIdade(25);

      Console.WriteLine(pessoa.nome);
      Console.WriteLine(pessoa.idade);


        // Create an ArrayList
        ArrayList arrayList = new ArrayList();

        // Add elements to the ArrayList
        arrayList.Add(1);
        arrayList.Add("Hello");
        arrayList.Add(3.14);
        arrayList.Add(true);

        // Display the elements in the ArrayList
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}