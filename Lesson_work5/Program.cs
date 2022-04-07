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
            var sw = File.AppendText("startup.txt");
            var time = DateTime.Now.ToString("HH:mm:ss tt");
            sw.WriteLine(time);
            Console.WriteLine($"В данный момент обновлено время {time}");
        }
    }
}
