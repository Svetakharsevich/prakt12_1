using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прак1._2
{
    internal class Program
    {
        static void massiv1()
        {

            string[] lines = File.ReadAllLines("file1.txt");
            double[,] num = new double[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] Temp = lines[i].Split(' ');
                for (int j = 0; j < Temp.Length; j++)
                    num[i, j] = Double.Parse(Temp[j]);
            }


        }
        static void massiv2()
        {
            if (File.Exists("massiv2.txt"))
            {
                StreamReader file = File.OpenText("file2.txt");
                while (!file.EndOfStream)
                {
                    string text = file.ReadLine();
                    var a = File.ReadAllText(text);
                    int[] a2 = a.Split(' ').Select(x => int.Parse(x)).ToArray();
                    Console.WriteLine(a2);
                }
                file.Close();
            }
            else Console.WriteLine("Файла нет");
        }

        static void Main(string[] args)
        {
            massiv1();
            //massiv2();
            Console.ReadKey();
        }
    }
}
