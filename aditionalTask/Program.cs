using System;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите простую арифметическую операцию, например '20 / 5': ");
            double result;
            try
            {
                if (!Calculator.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("Не удалось выполнить арифметическую операцию над числами, не правильный формат записи!");
                else
                    Console.WriteLine($"Результат вычислений: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Возникла ошибка: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
