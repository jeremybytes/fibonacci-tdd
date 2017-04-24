using NUnit.Framework;
using System.Linq;

namespace Fibonacci.Tests
{
    public class FibonacciSequenceTest
    {
        // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

        [Test]
        public void FibonacciSequence_FirstElement_IsOne()
        {
            var seq = new FibonacciSequence();
            var result = seq.First();
            Assert.AreEqual(1, result);
        }
    }
}
