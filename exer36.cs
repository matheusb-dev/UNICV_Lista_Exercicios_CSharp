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
        string texto = "Programação";

        string primeirosTres = texto.Substring(0, 3);

        Console.WriteLine("Texto original: " + texto);
        Console.WriteLine("Primeiros 3 caracteres: " + primeirosTres);
    }
}
