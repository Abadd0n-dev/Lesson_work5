using System;
using System.Runtime.Serialization.Formatters.Binary;
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
            const string file = "test.bin";

            Console.WriteLine("Введите числа от [0..255], через пробел");
            var input = Console.ReadLine()?.Split(' ');

            var array = new byte[input.Length];
            for (var i = 0; i < array.Length; i++)
            {
                if (!byte.TryParse(input[i], out var number))
                {
                    Console.WriteLine($"Неверное число {input[i]}");
                    return;
                }

                array[i] = number;
            }

            using (var bw = new BinaryWriter(File.OpenWrite(file)))
            {
                bw.Write(array);
                bw.Flush();
            }

            Console.WriteLine($"в файле сейчас находится {file}"); ; ;
            byte[] newData;
            using (var br = new BinaryReader(File.OpenRead(file)))
            {
                newData = br.ReadBytes(array.Length);
            }

            for (var i = 0; i < newData.Length; i++)
            {
                Console.Write(newData[i] + " ");
            }
        }
    }
}
