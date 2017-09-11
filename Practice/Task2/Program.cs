using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        /*
         2.	С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. 
         Каждая запись должна начинаться с новой строки.
        */
        static void Main(string[] args)
        {
            string writePath = @"C:\data\1.txt";
            string dirPath = @"C:\data";
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            string name = "Алишер";
            string surname = "Бекмухамбет";
            int age = 22;
            
            using (StreamWriter streamWriter = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine(name);
                streamWriter.WriteLine(surname);
                streamWriter.WriteLine(age);
            }
        }
    }
}
