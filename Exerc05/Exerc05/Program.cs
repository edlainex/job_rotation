using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoInvertido = string.Empty;
            int i;

            Console.WriteLine("Digite um texto");
            string textoDigitado = Convert.ToString(Console.ReadLine());

            for (i = textoDigitado.Length - 1; i >= 0; i--)
            {
                textoInvertido += textoDigitado[i];
            }

            Console.WriteLine("\r\nTexto invertido");

            Console.WriteLine(textoInvertido);

            Console.ReadKey();
        }
    }
}
