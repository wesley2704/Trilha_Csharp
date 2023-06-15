/*Problema "idades" 

Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os 
nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo. 

Exemplo: 
Dados da primeira pessoa: 
Nome: Maria Silva
Idade: 19
Dados da segunda pessoa: 
Nome: Joao Melo
Idade 20
A idade média de Maria Silva e Joao Melo é de 19.5 anos
*/

using System.Globalization;

namespace Exercicio_ProblemasIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nomeA,nomeB;
            int idadeA,idadeB;

            Console.WriteLine("informe o nome da primeira pessoa");
            nomeA = Console.ReadLine();

            Console.WriteLine("informe a idade da primeira pessoa");
            idadeA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da segunda pessoa:");
            nomeB = Console.ReadLine();

            Console.WriteLine("Informe a idade da segunda pessoa:");
            idadeB = int.Parse(Console.ReadLine());

            int idadeMedia = (idadeA + idadeB) / 2;

            Console.WriteLine("Idade média entre " + nomeA + " e " + nomeB + ": " + idadeMedia.ToString("F2",CI));

            Console.ReadLine();


        }
    }
}