/*-------------------------------------------------------------------
Questão 1: Coleção de Itens Raros com Variações de Baús
Contextualização:
Em um jogo de exploração, o jogador pode abrir diferentes tipos de baús em uma masmorra.
Cada tipo de baú possui uma variação na quantidade de itens raros que pode conter.
Comando:
Crie um programa em C# que simule a coleta de itens raros a partir de diferentes tipos de baús.
O programa deve:
1. Perguntar ao jogador quantos baús ele deseja abrir.
2. Perguntar ao jogador quantos tipos diferentes de baús existem no jogo.
3. Para cada tipo de baú, perguntar quantos baús desse tipo o jogador deseja abrir.
Para cada baú aberto, dependendo do tipo, gerar aleatoriamente a quantidade de itens raros
obtidos:
* Tipo A: 0 a 3 itens
* Tipo B: 1 a 5 itens
* Tipo C: 2 a 6 itens
* (Adapte conforme o número de tipos definidos pelo jogador)
O programa deve calcular e exibir a quantidade total de itens raros obtidos após abrir todos os
baús
@Lista: 03 - Classe de repetição
@Autor: Lucas Amaral Gonçalves
@Data: 27/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int qntBau, tipos, qntAbrir, inicio, fim;

        Console.WriteLine($"Digite a quantidade de baus dejesa abrir: ");
        qntBau = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a quantidade de tipos de bau se há: ");
        tipos = int.Parse(Console.ReadLine());

        for (int i = 0; i < tipos; i++)
        {
        bau:
            Console.WriteLine($"Digite a quantidade a se abri do {i + 1}° bau: ");
            qntAbrir = int.Parse(Console.ReadLine());

            inicio = random.Next(0, 5);
            fim = random.Next(5, 20);

            if (qntAbrir - qntBau < 0)
            {
                Console.WriteLine($"Quantidade insuficiente, tente novamente:");

                goto bau;
            }
            qntBau -= qntAbrir;

            for (int j = 0; j < qntAbrir; j++)
            {
                Console.WriteLine($"{j + 1}° bau do tipo {i + 1} é: {random.Next(inicio, fim)}");

            }
        }

    }
}