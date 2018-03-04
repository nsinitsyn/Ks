using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ks.Task1
{
  class Program
  {
    static void Main(string[] args)
    {
      var queue = new ThreadSafetyQueue<int>();

      var x = -1;
      var y = -1;
      var z = -1;

      Task.WaitAll(
        Task.Run(() => { queue.Push(1); }),
        Task.Run(() => { queue.Push(2); }),
        Task.Run(() => { x = queue.Pop("x"); }),
        Task.Run(() => { queue.Push(3); }),
        Task.Run(() => { y = queue.Pop("y"); }),
        Task.Run(() => { z = queue.Pop("z"); }),
        Task.Run(() => { queue.Push(4); }),
        Task.Run(() => { queue.Push(5); }),
        Task.Run(() => { queue.Push(6); }),
        Task.Run(() => { queue.Push(7); })
        );

      Console.WriteLine();
      Console.WriteLine($"x = {x}");
      Console.WriteLine($"y = {y}");
      Console.WriteLine($"z = {z}");


      Console.ReadKey();
    }
  }
}
