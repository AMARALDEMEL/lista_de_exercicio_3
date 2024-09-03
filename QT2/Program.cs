/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de 
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade.
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
* Fácil: 50 pontos por inimigo
* Médio: 100 pontos por inimigo
Serviço Nacional de Aprendizagem Industrial
Centro de Formação Profissional Antônio Urbano de Almeida
Técnico em Jogos Digitais
Lógica de Programação
Lista de Exercícios 3
3
* Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Classe De Repetição
@Autor: Lucas Amaral Goncalves
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nivel;
        int missoes, inim, final = 0, final1 = 0, final2 = 0, final3 = 0;
        Console.WriteLine(" Quantas missões foram completadas?: ");
        int.TryParse(Console.ReadLine(), out missoes);
        for (int i = 0; i < missoes; i++)
        {
            Console.WriteLine("Para cada missão, escreva qual o nível de dificuldade?: ");
            nivel = Console.ReadLine();
            if (nivel == "facil")
            {
                Console.WriteLine("escreva quantos inimigos você derrotou nessa missão?: ");
                int.TryParse(Console.ReadLine(), out inim);
                final = 50 * inim;
            }
            else if (nivel == "medio")
            {
                Console.WriteLine("escreva quantos inimigos você derrotou nessa missão?: ");
                int.TryParse(Console.ReadLine(), out inim);
                final1 = 100 * inim;
            }
            else if (nivel == "dificil")
            {
                Console.WriteLine("escreva quantos inimigos você derrotou nessa missão?: ");
                int.TryParse(Console.ReadLine(), out inim);
                final2 = 150 * inim;
            }
            final3 = final + final1 + final2;
        }
        Console.WriteLine($"Você ganhou {final3} pontos");
    }
}