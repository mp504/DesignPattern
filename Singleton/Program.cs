
namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigurationManager config1 = ConfigurationManager.Instance;
            ConfigurationManager config2 = ConfigurationManager.Instance;


            Console.WriteLine(ReferenceEquals(config1, config2)); //The ReferenceEquals  is used to determine whether two object references refer to the same instance of an object in memory
            Console.WriteLine(config1.Get("APIKey"));

        }
    }
}