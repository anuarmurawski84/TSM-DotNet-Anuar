using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифры для сложения: ");
            var data1 = Console.ReadLine();
            var data2 = Console.ReadLine();
            int iData1 = Convert.ToInt32(data1);
            int iData2 = Convert.ToInt32(data2);
            int result = iData1 + iData2;
            Console.WriteLine($"В результате сложения будет {result}");
            Console.ReadKey();
        }
    }
}
