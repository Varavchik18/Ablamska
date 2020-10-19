using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FunctionF
    {
        public int Fibonacci_function(int N)  // рекурсивная функция
        {
            if (N == 1 || N == 2)
                return 1; // первые 2 числа равны 1
            return Fibonacci_function(N - 1) + Fibonacci_function(N - 2); // складываем предыдущие 2 числа
        }
    }
}
