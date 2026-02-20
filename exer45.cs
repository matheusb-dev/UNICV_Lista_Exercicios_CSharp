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
        string entrada = "dez";
        double numero;

        bool sucesso = double.TryParse(entrada, out numero);

        if (sucesso)
        {
            Console.WriteLine("Entrada válida: " + numero);
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}
