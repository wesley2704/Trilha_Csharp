/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.Write("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                Console.WriteLine("Boa tarde!");
            }
        }
    }
*/

/*namespace Programa
    {
        class Program
        {
            static void Main(string[] args)
            {
                int x, soma;
                soma = 0;
                Console.Write("Digite o primeiro numero: ");
                x = int.Parse(Console.ReadLine());
                while (x != 0)
                {
                    soma = soma + x;
                    Console.Write("Digite outro numero: ");
                    x = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("SOMA = " + soma);
            }
        }
    }
*/

using System;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, x, soma;
            Console.Write("Quantos numeros serao digitados? ");
            N = int.Parse(Console.ReadLine());
            soma = 0;
            for (i = 1; i <= N; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}