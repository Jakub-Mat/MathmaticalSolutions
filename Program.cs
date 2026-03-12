using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class Kombinatorika
{
    public static long Factorial(int num)
    {
        if(num > -1)
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
            throw new ArgumentOutOfRangeException("Faktoriál lze vytvořit pouze z kladných čísel"); //tuhle vyjimku mi poradil Gemini
        }
        
    }
    public static long KombinacniCislo(int n, int k)
    {
        long combNum = 1;
        //return Factorial(n)/(Factorial(k) * Factorial(n-k));
        for (int i = n; i > n-k; i--)
        {
            combNum *= i;
        }
        combNum = combNum / Factorial(k);
        return combNum;
    }
}


class Run
{
    static void Main(string[] args)
    {
        int num = 5;
        long factNum = Kombinatorika.Factorial(num);
        Console.WriteLine($"Faktoriál čísla {num} je: {factNum}");

        Console.WriteLine($"Kombinačni cislo 5 na 3 je: {Kombinatorika.KombinacniCislo(5,3)}"); //
        Console.WriteLine($"Kombinačni cislo 21 na 2 je: {Kombinatorika.KombinacniCislo(21, 2)}"); //210
    }
}