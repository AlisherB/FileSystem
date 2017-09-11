using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Task1
{
    class Program
    {
        /*
        1.	Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений каждого из 256 возможных знаков. 
        */
        static void Main(string[] args)
        {
            string dirPath = @"C:\data";
            string writePath = @"C:\data\1.txt";
            string readPath = @"C:\data\1.txt";
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            try
            {
                WriteLine("Введите любую строку:");
                string str = ReadLine();
                using (StreamWriter writer = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    writer.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            try
            {
                using (StreamReader reader = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    int count = 0;
                    string symbol = reader.Peek().ToString();

                    while (reader.Read() != -1)
                    {
                        for (int i = 0; i < 256; i++)
                        {
                            if (symbol == i.ToString())
                            {
                                count++;
                                break;
                            }
                        }
                    }
                    WriteLine("Число появлений каждого из 256 возможных знаков = " + count);
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            ReadLine();
        }
    }
}
