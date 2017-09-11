using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace HW_FileSystem
{
    class Program
    {
        private static string dirPath = @"C:\data";
        private static string path = @"C:\data\input.txt";
        static void Main(string[] args)
        {
            string fib = "";
            string[] numbers = fib.Split(' ');
            int[] fibArray = new int[numbers.Length];

            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader streamReader = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        fib += streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                bool result = Int32.TryParse(numbers[i], out fibArray[i]);
            }

            int[] fibArrayTwo = new int[numbers.Length];
            fibArrayTwo[0] = fibArray[numbers.Length - 2] + fibArray[numbers.Length - 1];
            fibArrayTwo[1] = fibArray[numbers.Length - 1] + fibArrayTwo[0];

            for (int i = 2; i < numbers.Length; i++)
            {
                fibArrayTwo[i] = fibArrayTwo[i - 1] + fibArrayTwo[i - 2];
            }
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        streamWriter.Write(" " + fibArrayTwo[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            ReadLine();
        }
    }
}
