using System.Numerics;

class Program
{

    private static void Main(string[] args)
    {
        BigInteger n = 49000;
        BigInteger r = 600;
        Task<BigInteger> part1 = Task.Run(() => { return Factorial(n); });
        Task<BigInteger> part2 = Task.Run(() => { return Factorial(n-r); });
        Task<BigInteger> part3 = Task.Run(() => { return Factorial(r); });
        BigInteger chances = part1.Result / (part2.Result * part3.Result);
        Console.WriteLine(chances);
    }
    private static BigInteger Factorial(BigInteger n)
    {
        BigInteger result = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}