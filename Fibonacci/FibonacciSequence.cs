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
            for (int i = 1; true; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
