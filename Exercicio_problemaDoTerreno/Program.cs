/*Problema "terreno" 
Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma 
casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida, 
o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com 
duas casas decimais, conforme exemplo.

Exemplo 1: 
Digite a largura do terreno: 10.0
Digite o comprimento do terreno: 30.0
Digite o valor do metro quadrado: 200.00
Area do terreno = 300.00 
Preco do terreno = 60000.00

 */


using System.Globalization;

namespace Exercicio_problemaDoTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
           
           double largura, comprimento, valorMetroQradrado;


              Console.WriteLine("informe a largura do terreno");  
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o comprimento do terreno");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor do metro quadrado");
            valorMetroQradrado= double.Parse(Console.ReadLine());

            double area = largura * comprimento;

            double precoDoTerreno = area * valorMetroQradrado;


            Console.WriteLine("Área do terreno: " + area.ToString("F2",CI));
            Console.WriteLine("Preço do terreno: " + precoDoTerreno.ToString("F2",CI));

            Console.ReadLine();





        }
    }
}