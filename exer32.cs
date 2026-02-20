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
        decimal precoProduto = 150.00m;
        decimal desconto = 0.10m; // 10% de desconto

        decimal valorDesconto = precoProduto * desconto;
        decimal valorFinal = precoProduto - valorDesconto;

        Console.WriteLine("Preço original: R$ " + precoProduto);
        Console.WriteLine("Desconto: R$ " + valorDesconto);
        Console.WriteLine("Valor final: R$ " + valorFinal);
    }
}
