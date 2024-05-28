using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace РПМ_Практическая_работа_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] строки = { "яблоко", "картошка", "морковь", "салат оливье", "малина", "соль", "капуста" };

            // Создаем и запускаем поток с использованием ParameterizedThreadStart
            Thread thread = new Thread(new ParameterizedThreadStart(МаксДлинаСтроки));
            thread.Start(строки);

            thread.Join();
            Console.ReadKey();
        }

        static void МаксДлинаСтроки(object obj)
        {
            // Преобразуем параметр обратно в массив строк
            string[] строки = (string[])obj;

            string макс = строки.OrderByDescending(s => s.Length).First();

            Console.WriteLine("Строка максимальной длины: " + макс);
        }
    }
}
