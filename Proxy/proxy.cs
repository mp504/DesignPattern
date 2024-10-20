using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IExpensiveComputation
    {
        int Compute(int input);
    }


    // Real Subject
    public class ExpensiveComputation : IExpensiveComputation
    {
        public int Compute(int input)
        {
            // Simulate a long computation
            Console.WriteLine($"Computing result for {input}...");
            System.Threading.Thread.Sleep(2000); // Simulating delay
            return input * input; // Example computation
        }
    }
        // Proxy
    public class CachingProxy : IExpensiveComputation
    {
            private readonly ExpensiveComputation _realComputation;
            private readonly Dictionary<int, int> _cache;

            public CachingProxy()
            {
                _realComputation = new ExpensiveComputation();
                _cache = new Dictionary<int, int>();
            }

            public int Compute(int input)
            {
                if (_cache.ContainsKey(input))
                {
                    Console.WriteLine($"Returning cached result for {input}.");
                    return _cache[input];
                }

                // If not in cache, compute and store the result
                int result = _realComputation.Compute(input);
                _cache[input] = result;
                return result;
            }
    }
    
}
