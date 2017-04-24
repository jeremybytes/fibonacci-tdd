using System;
using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciSequence : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;

            int previous = 0;
            int current = 1;
            for (int i = 1; true; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
