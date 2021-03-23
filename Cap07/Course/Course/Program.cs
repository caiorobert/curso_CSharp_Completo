using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Inferência de tipos
            ////declaro o var, e C# na hora de receber o valor, sabe o tipo que vai dar para a variável
            //Console.WriteLine("Inferência de tipos");
            //var x = 10; //int
            //var y = 20.0; //double
            //var z = "Maria"; //string
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //Console.WriteLine("------------------------------");

            ////Ao invés de usar vários ifs, usar o switch case facilita na hora de testar varias possibilidades
            //Console.WriteLine("Usando Swich case");
            //int dia = int.Parse(Console.ReadLine());
            //string day;
            //switch (dia)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid value";
            //        break;
            //}
            //Console.WriteLine("Day: " + day);

            //Console.WriteLine("------------------------------");

            ////Expressão condicional ternária, opcional ao if else
            //Console.WriteLine("If ternário");
            ////Como ficaria com o if else
            //double preco = 34.5;
            //double desconto;
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            ////Como fica usando if ternário
            //desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine(desconto);
            //Console.WriteLine("------------------------------");

            ////Funções interessantes para string
            //Console.WriteLine("Funções interessantes para string");
            //string original = "abcde FGHIJ ABC abc DEFG ";
            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();
            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");
            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);
            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");
            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);
            //Console.WriteLine("Original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("IndexOf('bc'): " + n1);
            //Console.WriteLine("LastIndexOf('bc'): " + n2);
            //Console.WriteLine("Substring(3): -" + s4 + "-");
            //Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            //Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            //Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            //Console.WriteLine("IsNullOrEmpty: " + b1);
            //Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //Console.WriteLine("------------------------------");

            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1); //horário atual do sistema
            //Console.WriteLine(d1.Ticks); //o datetime armazena em Ticks(100 nanosegundos), que é todos os ticks passados do dia 1 do ano 1 até a era atual

            //Sobrecargas permitidas no DateTime
            Console.WriteLine("Demo - construtores");
            DateTime d1 = new DateTime(2000, 8, 15); //DateTime(ano, mes, dia)
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); //DateTime(ano, mes, dia, hora, minuto, segundo)
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275); //DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo)
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - Now, UtcNow, Today");
            d1 = DateTime.Now;
            d2 = DateTime.UtcNow;
            d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - Parse");
            d1 = DateTime.Parse("2000-08-15");
            d2 = DateTime.Parse("2000-08-15 13:05:58");
            d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - ParseExact");
            d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("TimeSpan");
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - construtores");
            t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - métodos From");
            t1 = TimeSpan.FromDays(1.5);
            t2 = TimeSpan.FromHours(1.5);
            t3 = TimeSpan.FromMinutes(1.5);
            t4 = TimeSpan.FromSeconds(1.5);
            t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Propriedades do DateTime");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Formatações do DateTime");
            d = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Propriedades e Operações com TimeSpan");
            Console.WriteLine();
            Console.WriteLine("Demo: MaxValue, MinValue, Zero");
            TimeSpan tt1 = TimeSpan.MaxValue;
            TimeSpan tt2 = TimeSpan.MinValue;
            TimeSpan tt3 = TimeSpan.Zero;
            Console.WriteLine(tt1);
            Console.WriteLine(tt2);
            Console.WriteLine(tt3);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - propriedades");
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - operações");
            t1 = new TimeSpan(1, 30, 10);
            t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine($"TimeSpan 1: {t1}");
            Console.WriteLine($"TimeSpan 2: {t2}");
            Console.WriteLine($"Add (t1 + t2): {sum}");
            Console.WriteLine($"Substract (t1 - t2): {dif}");
            Console.WriteLine($"Multiply (t2 * 2.0): {mult}");
            Console.WriteLine($"Divide (t2 / 2.0): {div}");

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Demo - operações");

        }
    }
}
