using System;

namespace Test
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input searched value");
            string searchedValue = Console.ReadLine();
            Console.WriteLine("Input substitution value");
            string substitution = Console.ReadLine();

            var codeString = "using System;{1}{1} namespace Test{1}{2} {0}class Program{1} {0}{2}{1}{0}  static void Main() {1}{0}{0}{2}{1}{0}{0}{0} var s={6};{1}{0}{0}{0} Console.Write(s, {4}{5}t{4}, {4}{5}n{4}, {4}{2}{4}, {4}{3}{4}), {4}{5}{4}, {4}{5}{5}{4}, s; {1}{1} Console.Readline(); {1}{0}{0}{3} {1}{0}{3} {1}{3}";


            char[] QuineArray = codeString.ToCharArray();
            if (codeString.IndexOf(searchedValue, 0, codeString.Length) >= 0)
            {
                var replacement = codeString.Replace(searchedValue, substitution);
                Console.WriteLine(ReverseString(replacement));

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(ReverseString(codeString));
                Console.ReadLine();
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}