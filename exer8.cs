/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    
    NOME: Otávio Augusto Zangelmi Costa
    RA: 159752-2023

    NOME: Luiz Eduardo Marques da Silva 
    RA:168685-2024
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EX_C__1_15
{
    internal class ex8
    {
        public static void EX8()
        {
            decimal Real = 199.99m;

            string Formatador = Real.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));

            Console.WriteLine(Formatador);
            //
        }
    }
}
