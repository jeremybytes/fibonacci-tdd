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
            yield return 1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
