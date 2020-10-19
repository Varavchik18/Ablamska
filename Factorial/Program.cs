using System;

class Program
{
    public static int Main()
    {
        Console.Write("Введите число : ");
        int num = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
            if (i == num)
            {
                Console.Write("{0}", i);
            }
            else
            {
                Console.Write("{0} * ", i);
            }
        }
        Console.Write(" = {0}", factorial);
        Console.ReadKey();
        return 0;
    }
}