using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência de Fibonacci");

            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fib1, fib2, cont;

            if (num < 0) 
            {
                Console.WriteLine("Número invalido!");
            }
            else 
            {
                fib1 = 0;
                fib2 = 1;
                cont = 0;
                Console.WriteLine("\r\n--------------------------------\r\n");

                while (cont <= num) 
                {
                    
                    int fib3 = fib1 + fib2;

                    if (fib3 == num || fib1 == num)
                    {
                        Console.WriteLine("O número digitado pentence a sequência de Fibonacci!");
                        break;
                    }
                    else
                    {
                        if (cont == num)
                        {
                            Console.WriteLine("O número digitado NÃO pentence a sequência de Fibonacci.");
                            break;
                        }
                        else
                        {
                            fib1 = fib2;
                            fib2 = fib3;
                            cont++;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
