namespace Zadrekursiq
{
    internal class Program
    {
        static int Sum(int n)
        {
            if (n <= 1) return 1;
            else return n*Sum(n - 1);

        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int sum = Sum(n);
            Console.WriteLine($"sum={sum}");
        }
    }
}