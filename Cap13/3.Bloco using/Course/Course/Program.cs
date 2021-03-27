using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\source\repos\curso_CSharp_Completo\Cap13\3.Bloco using\file1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open)) //usando o using(){} quando seu uso acabar, o que estiver dentro dela fecha automaticamente
                {
                    using (StreamReader sr = new StreamReader(fs)) //mesmo exemplo, abriu o StreamReader, usou, no final fecha
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }

                using (StreamReader sr = File.OpenText(path)) //mesmo exemplo, só que sem usar o FileStream
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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