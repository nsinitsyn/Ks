using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ks.Task2
{
  class Program
  {
    static void Main(string[] args)
    {
      var solution = new Solution();

      var results = new List<List<(int, int)>>
      {
        solution.Calculate(new [] { 1, 1, 2, 1, 1, 0, 1 }, 2),
        solution.Calculate(new int [] { }, 2),
        solution.Calculate(new [] { 1, 1, 2, 1, 1, 0, 1 }, 55),
        solution.Calculate(new [] { 0, 0 }, 0),
        solution.Calculate(new [] { 1, 1, 1, 9, 9, 5, 4, 8, 1, 1, 2, 4, 6, 3, 5, 15 }, 10)
      };

      // Печать результатов
      var index = 0;
      foreach (var result in results)
      {
        Console.Write($"Result {index++}: ");
        foreach (var s in result)
        {
          Console.Write($"({s.Item1}, {s.Item2}) ");
        }
        Console.WriteLine();
      }

      Console.ReadKey();
    }
  }
}
