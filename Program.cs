using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class Kombinatorika
{
    public static long Factorial(int num)
    {
        if(num > 0)
        {
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        else
        {
            throw new Exception("Faktoriál lze vytvořit pouze z kladných čísel");
        }
        
    }
    public static long KombinacniCislo(int n, int k)
    {
        return Factorial(n)/(Factorial(k) * Factorial(n-k));
    }
}


class Run
{
    static void Main(string[] args)
    {
        int num = 15;
        long factNum = Kombinatorika.Factorial(num);
        Console.WriteLine($"Faktoriál čísla {num} je: {factNum}");
    }
}