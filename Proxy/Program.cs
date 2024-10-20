// Client Code
using Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        IExpensiveComputation computation = new CachingProxy();

        // First computation (not cached)
        Console.WriteLine(computation.Compute(4)); // Should compute
        // Second computation (should use cache)
        Console.WriteLine(computation.Compute(4)); // Should use cache

        // Another computation (not cached)
        Console.WriteLine(computation.Compute(5)); // Should compute
        // Using cache again
        Console.WriteLine(computation.Compute(5)); // Should use cache
    }
}