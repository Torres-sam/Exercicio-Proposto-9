using System;
using System.Net.WebSockets;

namespace MyApp
{
    internal class ExercicioProposto9
    {
        static void Main(string[] args)
        {

            Console.Write("Digite os Dois valores: ");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);           
            int b = int.Parse(valores[1]);


            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("O primeiro número é múltiplo do segundo.");
            } 
            else {
                Console.WriteLine("O primeiro número não é múltiplo do segundo.");

            }
    

        }
    }
}