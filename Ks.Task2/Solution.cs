using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ks.Task2
{
  class Solution
  {
    public List<(int, int)> Calculate(int[] z, int x)
    {
      var result = new List<(int, int)>();

      Array.Sort(z);

      var left = 0;
      var right = z.Length - 1;
      while (left < right)
      {
        var sum = z[left] + z[right];
        if (sum == x)
        {
          result.Add((z[left], z[right]));
          left++;
          right--;
        }
        else if (sum < x)
        {
          left++;
        }
        else
        {
          right--;
        }
      }

      return result;
    }
  }
}
