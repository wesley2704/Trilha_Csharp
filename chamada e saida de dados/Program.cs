

/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, y;
            X = 10;
            y = 20;
            Console.WriteLine(X);
            Console.WriteLine(y);
        }
    }
}*/
/*using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x;
            x = 2.235698;
            Console.WriteLine(x.ToString("f2",CI));
        }
    }
}*/

using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int idade;
            double salario;
            string nome;
            char sexo;

            idade = 32;
            salario = 4566.90;
            nome = "maria";
            sexo = 'A';

         Console.WriteLine("a funcionaria " + nome +
                " , sexo" + sexo + ",ganha"+ 
                salario.ToString("f2")+ "e tem " +
                idade + "anos ");
        }
    }
}