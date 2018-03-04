using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ks.Task1
{
  public class ThreadSafetyQueue<T>
  {
    private Queue<T> _queue = new Queue<T>();

    public void Push(T item)
    {
      lock (_queue)
      {
        Console.WriteLine($"Push {item}");
        _queue.Enqueue(item);
        Monitor.Pulse(_queue);
      }
    }

    public T Pop(string debugInfo)
    {
      lock (_queue)
      {
        Console.WriteLine($"Pop for {debugInfo}");

        Monitor.Wait(_queue);

        var v = _queue.Dequeue();
        Console.WriteLine($"Deque {v} for {debugInfo}");
        return v;
      }
    }
  }
}
