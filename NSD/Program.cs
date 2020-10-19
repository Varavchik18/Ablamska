using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Алгоритм Евклида");
        Console.Write("A = ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Наибольший общий делитель чисел {0} и {1} равен {2}", a, b, GCD(a, b));
        Console.ReadLine();
    }
}