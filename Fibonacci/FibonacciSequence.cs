using System;
using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciSequence : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            var value = (current: 0L, next: 1L);

            while (true)
            {
                value = (value.next, value.current + value.next);
                yield return value.current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
