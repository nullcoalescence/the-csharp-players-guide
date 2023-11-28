namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // level 3 challenge
            Console.WriteLine("Something else...");

            // Challenge
            Console.WriteLine("One more Console.WriteLine()");
            Console.WriteLine("Another Console.WriteLine()");
            Console.WriteLine("Yet another Console.WriteLine()");
            Console.WriteLine("Uno mas Console.WriteLine()");
            Console.WriteLine("Last but not least Console.WriteLine()");

            // Challenge
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            var name = Console.ReadLine();

            Console.WriteLine($"Noted, {name} got bread.");
        }
    }
}
