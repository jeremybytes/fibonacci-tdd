using NUnit.Framework;
using System.Linq;

namespace Fibonacci.Tests
{
    public class FibonacciSequenceTest
    {
        // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

        [TestCase(0,1)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        [TestCase(4,5)]
        public void FibonacciSequence_Element_IsValue(int n, int expected)
        {
            var seq = new FibonacciSequence();
            var result = seq.ElementAt(n);
            Assert.AreEqual(expected, result);
        }
    }
}
