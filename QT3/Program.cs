/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de 
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Classe De Repetição
@Autor: Lucas Amaral Gonçalves
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nivel;
        int itens, inven, quant, totalIntens = 0;
        Console.WriteLine(" escreva quantos tipos diferentes de itens ele deseja armazenar no inventário: ");
        int.TryParse(Console.ReadLine(), out itens);
        Console.WriteLine(" escreva qual é a capacidade máxima do inventário: ");
        int.TryParse(Console.ReadLine(), out inven);
        for (int i = 0; i < itens; i++)
        {
            Console.WriteLine("escreva qual o nome do item?");
            nivel = Console.ReadLine();
            Console.WriteLine("escreva quantos itens desse tipo ele possui: ");
            int.TryParse(Console.ReadLine(), out quant);
            totalIntens += quant;
        }
        if (totalIntens <= inven)
        {
            Console.WriteLine($"Tem-se {totalIntens} itens,Dentro da capacidade");
        }
        else
        {
            Console.WriteLine($"Tem-se {totalIntens} itens,fora da capacidade");
        }
    }
}