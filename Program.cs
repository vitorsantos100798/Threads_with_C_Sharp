//Análise e Desenvolvimento de Sistemas – Matutino
// Aluno: Vitor inacio camargo dos Santos Ra: 1570482111029

using System;
using System.Threading;

class ExercicioThreads
{
  static void Main()
  {
    Console.Write("Insira o número de cálculos a serem executados: ");
    int numCalculos = int.Parse(Console.ReadLine());

    Thread[] threads = new Thread[numCalculos];
    for (int i = 0; i < numCalculos; i++)
    {
      Console.Write($"Insira o número para o cálculo desejado: {i + 1}: ");
      int num = int.Parse(Console.ReadLine());

      threads[i] = new Thread(() => CalcularFatorial(num))
      {
        Name = $"Thread-{i + 1}"
      };
      threads[i].Start();
    }

    foreach (Thread thread in threads)
    {
      thread.Join();
    }
  }

  static void CalcularFatorial(int num)
  {
    int fatorial = 1;
    for (int i = 1; i <= num; i++)
    {
      fatorial *= i;
      Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Iteração {i}: {fatorial}");
    }
    Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Fatorial de {num}: {fatorial}");
  }
}
