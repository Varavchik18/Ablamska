using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class TestMath
    {
        public List<double> ValueList = new List<double>() { };
        public int Count =0;
        public double mean = 0;

        public void CallInterface()
        {
            Console.WriteLine("Выбери функцию: \n\t1. Добавить значения \n\t2. отобрзаить значения \n\t3. Среднее \n\t4.сума элементов \n\t5.Angle Coresponds \n\t6.Sort List \n\t7.Find Quartille");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                   AddValue();
                    CallInterface();
                    break;
                case 2:
                    DisplayValues();
                    CallInterface();
                    break;
                case 3:
                    Console.WriteLine(FindMean());
                    CallInterface();
                    break;
                case 4:
                    Console.WriteLine(FindSumList());
                    CallInterface();
                    break;

                case 5:
                    Console.WriteLine(FindAngleCorresponds());
                    CallInterface();
                    break;

                case 6:
                    SortList();
                    CallInterface();
                    break;

                case 7:
                    Console.WriteLine("какую квартиль найти?");
                    Console.WriteLine(FindQuartille(Convert.ToInt32(Console.ReadLine()))); 

                    CallInterface();
                    break;

                default:
                    Environment.Exit(1);
                    break;
            }
        }

        public void AddValue () {
            Console.WriteLine("Сколько значений добавить?");
            Count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Добавьте значения");
            for (int i = 0; i < Count; i++)
            {
                ValueList.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        private int GetTruncateFrom(double value)
        {
            double intValue = Math.Truncate(value);
            int convertedValue = Convert.ToInt32(intValue);
                return convertedValue; 
        }

        private double GetDivisionPartFrom(double value) {

            double divPart = value % GetTruncateFrom(value);
                return divPart;
        }

        private double GetNumQuartille(int Num) {
            double NumQ = 0;
            
            switch (Num)
            { 
                case 1:
                    NumQ = 0.25 * (Count + 1);
                    break;
                case 2:
                    NumQ = 0.5 * (Count + 1);
                    break;
                case 3:
                    NumQ = 0.75 * (Count + 1);
                    break;
            }

            return NumQ;
        }

        public double FindQuartille(int NumQ)
        {
            double value_Q = 0;

            switch (NumQ)
            {
                case 1: double NumQ1 = GetNumQuartille(1);
                    value_Q = ValueList[GetTruncateFrom(NumQ1)-1] + GetDivisionPartFrom(NumQ1) * (ValueList[GetTruncateFrom(NumQ1)] - ValueList[GetTruncateFrom(NumQ1)-1]);
                    break;
                case 2: double NumQ2 = GetNumQuartille(2);
                    value_Q = ValueList[GetTruncateFrom(NumQ2)-1] + GetDivisionPartFrom(NumQ2) * (ValueList[GetTruncateFrom(NumQ2)] - ValueList[GetTruncateFrom(NumQ2)-1]);
                    break;
                case 3: double NumQ3 = GetNumQuartille(3);
                    value_Q = ValueList[GetTruncateFrom(NumQ3)-1] + GetDivisionPartFrom(NumQ3) * (ValueList[GetTruncateFrom(NumQ3)] - ValueList[GetTruncateFrom(NumQ3)-1]);
                    break;
            }
            
            return value_Q;
        }


        public void SortList() {
            ValueList.Sort(); 
            
            foreach (double i in ValueList)
                Console.WriteLine(i);
        }

        public void DisplayValues() {
            Console.WriteLine("List Values");
            foreach (double i in ValueList)
            {
                Console.WriteLine(i);
            }
        }

        public double FindSumList() {
            double SumList = 0;

            foreach (double i in ValueList)
                SumList += i;
            return SumList;
        }

        public double FindMean() {
            mean = FindSumList() / Count;
            return mean;
        }

        public double FindAngleCorresponds()
        {
            double AngleCoresp = 0;
            AngleCoresp = 360/FindSumList();

            return AngleCoresp;
        }
    }
}
