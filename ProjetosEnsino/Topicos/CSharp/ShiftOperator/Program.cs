// using System;
using System.Diagnostics;
// using System.Threading;

class Program
{
  static void Main()
  {
    int frames = 0;
    Stopwatch stopwatch = new();
    stopwatch.Start();

    while (true)
    {
      // Simula a renderização de um frame
      RenderFrame();
      frames++;

      // A cada segundo, calcula e exibe o FPS
      if (stopwatch.ElapsedMilliseconds >= 1000)
      {
        Console.Clear(); // Limpa o console
        Console.WriteLine($"FPS: {frames}");
        frames = 0; // Reseta o contador de frames
        stopwatch.Restart(); // Reinicia o cronômetro
      }

      // Simula um pequeno atraso para não sobrecarregar a CPU
      // Thread.Sleep(16); // Aproximadamente 60 FPS
    }
  }

  static void RenderFrame()
  {
    int numA = 10;
    int numB = 20;
    int resultado = 0;

    for (int i = 0; i < 1000000; i++)
    {
      // resultado = (numA + numB) / 2; // FPS: 1012
      resultado = (numA + numB) >> 1; // FPS: 1402
    }
  }
}