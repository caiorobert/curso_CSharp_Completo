using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\source\repos\curso_CSharp_Completo\Cap13\4.StreamWriter\file1.txt";
            string targetPath = @"D:\source\repos\curso_CSharp_Completo\Cap13\4.StreamWriter\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}