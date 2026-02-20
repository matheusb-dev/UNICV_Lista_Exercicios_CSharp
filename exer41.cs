/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    
    NOME: Otávio Augusto Zangelmi Costa
    RA: 159752-2023

    NOME: Luiz Eduardo Marques da Silva 
    RA:168685-2024
*/

using System;

public class Class1
{
	public Class1()
	{
        double numero = 7.5678;

        double arredondado = Math.Round(numero, 2); // 2 casas decimais

        Console.WriteLine("Número original: " + numero);
        Console.WriteLine("Número arredondado: " + arredondado);
    }
}
