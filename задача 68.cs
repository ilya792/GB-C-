namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of M:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value of N:");
            int n = int.Parse(Console.ReadLine());

            int result = Ackermann(m, n);
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m > 0 && n == 0)
                return Ackermann(m - 1, 1);
            else
                return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}