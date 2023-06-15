/*Problema "troco" 
Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia. 
O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto, 
e o valor em dinheiro dado pelo cliente (suponha que haja dinheiro suficiente). Seu programa deve 
mostrar o valor do troco a ser devolvido ao cliente. 

Exemplo 1: 
Preço unitário do produto: 8.00
Quantidade comprada: 2
Dinheiro recebido: 20.00
TROCO = 4.00 

Exemplo 2: 
Preço unitário do produto: 30.00
Quantidade comprada: 3
Dinheiro recebido: 100.00
TROCO = 10.00
*/


using System.Globalization;

namespace Exercicio_Troco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double valorProduto;
            int Quantidade;
            double dinheiroRecebido;

            Console.WriteLine("Informe o preço unitário do produto:");
            valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de unidades compradas:");
            Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em dinheiro dado pelo cliente:");
            dinheiroRecebido = double.Parse(Console.ReadLine());

            double valorTotal = valorProduto * Quantidade;
            double troco = dinheiroRecebido - valorTotal;

            Console.WriteLine("Troco a ser devolvido: " + troco.ToString("F2" , CI));

            Console.ReadLine();

        }
    }
}