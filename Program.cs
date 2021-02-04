using System;
using System.Globalization;

namespace Secao7
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula85 - Inferencia de tipos - palavra var - o tipo do dado digitado, define qual o tipo da variavel
            /*
            var x = 10;
            var y = 10.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */

            //aula86 switch case
            /*
            int x = int.Parse(Console.ReadLine());
            string day;
            
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalide value";
                    break;
            }
            Console.WriteLine("Day: " + day);
            */

            //aula87 - expressão condicional ternária
            /*
            int a = (2 > 4) ? 20 : 50;
            Console.WriteLine(a);
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 :  preco * 0.05;
            Console.WriteLine("Desconto: " + desconto);
            */

            //aula88 - Funçoes interessantes para string
            /*
            string original = "abcde FGHIJ ABC abc DEFG   ";
            string s1 = original.ToUpper();//Tudo maiusculo
            string s2 = original.ToLower(); //Tudo minusculo
            string s3 = original.Trim(); //remove espaço antes e depois da string

            int n1 = original.IndexOf("bc");//primeira ocorrencia de bc
            int n2 = original.LastIndexOf("bc");//ultima ocorrencia de bc

            string s4 = original.Substring(3);//corta a string a partir da 3 posição em diante
            string s5 = original.Substring(3,5);//corta a string a partir da 3 posição e corta em 5 caracteres

            string s6 = original.Replace('a', 'x');//troca todo caractere 'a' pelo 'x'
            string s7 = original.Replace("abc", "xy");//troca todo caractere 'a' pelo 'x'

            bool b1 = string.IsNullOrEmpty(original);//testar se a string é nula ou vazia
            bool b2 = string.IsNullOrWhiteSpace(original); //testar se a string é nula ou espaço em branco


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper:  -" + s1 + "-");
            Console.WriteLine("ToLower:  -" + s2 + "-");
            Console.WriteLine("Trim   :  -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOf('bc'): -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a' , 'x': -" + s6 + "-");
            Console.WriteLine("Replace('abc' , 'xy': -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            */

            //aula89 - DateTime
            /*
            DateTime d1 = DateTime.Now;//horário atual do sitema
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2020, 01, 08);
            DateTime d3 = new DateTime(2020, 01, 08, 21, 29, 59);

            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;// horário de greenwich

            DateTime d6 = DateTime.Parse("2020-08-15");
            DateTime d7 = DateTime.Parse("2020-08-15 13:05:20");

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine("Parse:");
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            */

            //aula 91 - Propriedades e operações com DateTime
            /*
            DateTime d1 = new DateTime(2021, 01, 08, 21, 51, 59);
            Console.WriteLine(d1);
            Console.WriteLine("1) Date: " + d1.Date);
            Console.WriteLine("2) Day: " + d1.Day);
            Console.WriteLine("3) DayOfWeek: " + d1.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d1.DayOfYear);
            Console.WriteLine("5) Hour: " + d1.Hour);
            Console.WriteLine("6) Kind: " + d1.Kind);
            Console.WriteLine("7) Millisecond: " + d1.Millisecond);
            Console.WriteLine("8) Minute: " + d1.Minute);
            Console.WriteLine("9) Month: " + d1.Month);
            Console.WriteLine("10) Second: " + d1.Second);
            Console.WriteLine("11) Ticks: " + d1.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d1.TimeOfDay);
            Console.WriteLine("13) Year: " + d1.Year);
            Console.WriteLine();
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();
            DateTime d2 = d1.AddDays(7);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            DateTime d3 = d1.AddMinutes(5);
            Console.WriteLine(d3);
            TimeSpan t = d2.Subtract(d1);
            Console.WriteLine(t);
            */

            //aula 93
            
            DateTime d1 = new DateTime(2021, 01, 08, 22, 18, 25, DateTimeKind.Local);

            DateTime d2 = new DateTime(2021, 01, 08, 22, 18, 25, DateTimeKind.Utc);
            
            DateTime d3 = new DateTime(2021, 01, 08, 22, 18, 25);

            Console.WriteLine(d1);
            Console.WriteLine("d1 kind: "+ d1.Kind);
            Console.WriteLine("d1 To Local: " + d2.ToLocalTime());
            Console.WriteLine("di To Utc" + d3.ToUniversalTime());
            Console.WriteLine("Olá, eu sou um teste");
            




        }
    }
}
