/*Problema "soma" 

Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes 
números. 

Exemplo 1: 
Digite o valor de X: 8
Digite o valor de Y: 10
SOMA = 18 
Exemplo 2: 
Digite o valor de X: 12
Digite o valor de Y: 31
SOMA = 43
*/


namespace Exercicio_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            int Y;

            Console.WriteLine("digite o valor de X:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor de Y:");
            Y = int.Parse(Console.ReadLine());


            int soma = X + Y;

            Console.WriteLine("a soma e:" + soma);


        }
    }
}