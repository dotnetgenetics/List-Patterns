namespace ListPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 5, 6, 7, 8 };

            // List and constant patterns 
            Console.WriteLine(numbers is [5, 6, 7, 8]); // True 
            Console.WriteLine(numbers is [5, 6, 7]); // False

            // List and discard patterns 
            Console.WriteLine(numbers is [_, 6, _, 8]); // True 
            Console.WriteLine(numbers is [.., 7, _]); // True
            Console.WriteLine(numbers is [5, .., 8]); // True
            Console.WriteLine(numbers is [5, .., 7]); // False

            // List and logical patterns 
            Console.WriteLine(numbers is [_, >=6, _, _]); // True
            Console.WriteLine(numbers is [<=5, 6, _, >=7]); // True

            Console.ReadLine();
        }
    }
}
