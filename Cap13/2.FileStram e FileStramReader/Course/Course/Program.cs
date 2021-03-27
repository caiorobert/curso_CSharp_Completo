using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = null; //Posso usar o objeto genérico e passar o resultado para o objeto específico abaixo
            StreamReader sr = null;
            try
            {
                string path = @"D:\source\repos\curso_CSharp_Completo\Cap13\2.FileStram e FileStramReader\file1.txt";

                //fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path); //Ou eu uso o objeto File, que já tem no método OpenText a intanciação do FileStream, ai eu não preciso usar ele explicitamente
                
                //string line = sr.ReadLine(); //Dessa forma estou lendo somente a primeira linha do arquivo.
                //Console.WriteLine(line);
                
                while (!sr.EndOfStream) //Com o while, eu verifico com o método EndOfStream se tem mais linhas no arquivo, e com o loop, eu imprimo cada linha
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close(); //Como eu não declarei o FileStream, não preciso fechar seu uso
            }
        }
    }
}
