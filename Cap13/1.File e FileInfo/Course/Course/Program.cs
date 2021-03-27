using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"D:\source\repos\curso_CSharp_Completo\Cap13\1.File e FileInfo\file1.txt";
                string targetPath = @"D:\source\repos\curso_CSharp_Completo\Cap13\1.File e FileInfo\file2.txt";
                string[] lines = File.ReadAllLines(sourcePath);

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
