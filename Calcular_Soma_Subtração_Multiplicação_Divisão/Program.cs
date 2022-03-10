using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Soma_Subtração_Multiplicação_Divisão
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calculadora Simples";

            int numero1, numero2, resultado = 0;


            string operacao;



            Console.WriteLine("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            operacao = Console.ReadLine();  


            // Realizando as Operações


            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;

                default:
                    Console.WriteLine("Operação Inválida");
                    break;

            }

            Console.WriteLine("Resultado: " + numero1 + " " + operacao + " " + numero2 + " " + "=" + " " + resultado );

     






            Console.ReadKey();
        }
    }
}
