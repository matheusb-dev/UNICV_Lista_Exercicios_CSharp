/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    
    NOME: Otávio Augusto Zangelmi Costa
    RA: 159752-2023

    NOME: Luiz Eduardo Marques da Silva 
    RA:168685-2024
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__1_15
{
    internal class ex33
    {
        public static void EX33()
        {
            int bas;
            int altura;
            int resultado;

            Console.WriteLine("Calcule a area de um retangulo");

            Console.WriteLine("Digite a Base: ");
            bas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            resultado = bas * altura;

            Console.WriteLine("Resultado: " + resultado);

        }
    }
}
