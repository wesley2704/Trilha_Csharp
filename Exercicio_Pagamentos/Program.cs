/*Problema "pagamento" 
Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) recebe por hora, e a 
quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor do pagamento do funcionário com 
uma mensagem explicativa, conforme exemplo. 

Exemplo 1: 
Nome: Joao Silva
Valor por hora: 50.00
Horas trabalhadas: 60
O pagamento para Joao Silva deve ser 3000.00 

Exemplo 2: 
Nome: Maria Dias
Valor por hora: 60.00
Horas trabalhadas: 100
O pagamento para Maria Dias deve ser 6000.00
*/

using System.Globalization;

namespace Exercicio_Pagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double hora;
            int horasTrabalhadas;

            Console.WriteLine("diga o nome do funcionario:");
            nome = Console.ReadLine();
            
            Console.WriteLine("diga o valor que ele recebe por hora:");
            hora = double.Parse(Console.ReadLine());

            Console.WriteLine("diga aquantidades e horas trabalhadas:");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            double salario = hora * horasTrabalhadas;


            Console.WriteLine("O funcionário " + nome + " deve receber R$" + salario.ToString("F2" + CI ));

            Console.ReadLine();



        }
    }
}