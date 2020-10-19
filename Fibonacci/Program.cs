using System;
using System.Reflection;

namespace Fibonacci
{
    class Q
    {
       [STAThread]
     static void Main(string[] args)
     {
       string s = "using System;{0}namespace quine{0}{2}{0}{1}class Program{0} {1}{2}{0}{1}{1}[STAThread]{0}{1}{1}static void Main(string[] args){0}{1}{1}{2}{0}{1}{1}{1} string s = {4}{6}{4};{0}{1}{1}{1} Console.Write(s, Environment.NewLine, {4}{5}t{4}, {4}{2} {4}, {4}{3}{4}, {4}{5}{4}{4}, {4}{5}{5}{4}, s);{0}{1}{1}{3}{0}{1}{3}{0}{3} ";
       Console.Write(s, Environment.NewLine, "\t", "{", "}", "\"", "\\", s);
            Console.ReadKey();
     }
    }
}
