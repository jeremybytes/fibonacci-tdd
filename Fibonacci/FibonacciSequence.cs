using System;
using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciSequence : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            yield return 1;

            long previous = 0;
            long current = 1;
            while (true)
            {
                try
                {
                    long next = checked(previous + current);
                    previous = current;
                    current = next;
                }
                catch (OverflowException)
                {
                    break;
                }
                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
