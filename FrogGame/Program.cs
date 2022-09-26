namespace FrogGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int shortJump;
            int longJump;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Froggy the frog must make his way to the princess, and get his kiss.");
            Console.WriteLine("But he desperately needs your help...");
            Console.Write("How many metres is a short jump for the frog? Insert a number: ");
            shortJump = int.Parse(Console.ReadLine());
            Console.Write("How many metres is a long jump for the frog? Insert a number: ");
            longJump = int.Parse(Console.ReadLine());
            Console.Write("How many metres is it to the princess? Insert a number: ");
            var steps = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            //how many possible ways
            int FibonacciCount(int x)
            {
                if (x <= shortJump)
                    return x/shortJump;
                return FibonacciCount(x - shortJump) + FibonacciCount(x - longJump);
            }

            //number of ways using fibonacci
            Console.WriteLine("\nNumber of possible ways are: " + FibonacciCount(steps+shortJump));

            //most efficient way
            int tempModulus = longJump;
            longJump = steps / longJump;
            if (steps > shortJump)
                shortJump = (steps % tempModulus) / shortJump;

            Console.WriteLine("Most efficient way for the frog is:");
            Console.WriteLine($"Long jumps: {longJump}");
            Console.WriteLine($"Short jumps: {shortJump}");

            Console.WriteLine("\nPress any key to quit.");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}