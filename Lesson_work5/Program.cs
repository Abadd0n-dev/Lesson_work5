using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_work5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расположение файла");
            var path = Console.ReadLine();
            if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Неверно указанный путь");
                return;
            }

            if (!path.EndsWith(".txt")) path += ".txt";
            var fs = new FileStream(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
            var sw = new StreamWriter(fs);


            Console.WriteLine("Введите данные для текстового файла, нажмите esc, чтобы остановиться");
            sw.AutoFlush = true;
            while (true)
            {
                var input = Console.ReadKey();

                if (input.Key == ConsoleKey.Escape)
                    break;
                if (input.Key == ConsoleKey.Enter)
                {
                    sw.Write("\n");
                    Console.WriteLine();
                }
                else sw.Write(input.KeyChar);
            }
            Console.WriteLine("Записанно");
        }
    }
}
