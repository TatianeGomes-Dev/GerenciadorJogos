using System;
using System.Collections.Generic;

public class GerenciadorJogos
{
    private List<Jogo> jogos = new List<Jogo>(); // Usamos List para facilitar a manipulação

    // Adiciona um novo jogo à lista
    public void Adicionar(Jogo novo)
    {
        jogos.Add(novo);
    }

    // Exibe todos os jogos com suas informações
    public void Exibir()
    {
        if (jogos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        int contador = 1;
        foreach (var jogo in jogos)
        {
            Console.WriteLine($"{contador++}. Nome: {jogo.Nome}, Preço: R$ {jogo.Preco:F2}, Gênero: {jogo.Genero}, Estoque: {jogo.Estoque}");
        }
    }

    // Remove um jogo pelo índice
    public void Remover(int posicao)
    {
        if (posicao < 1 || posicao > jogos.Count)
        {
            Console.WriteLine("Posição inválida! O produto não foi encontrado.");
            return;
        }

        jogos.RemoveAt(posicao - 1); // Subtrai 1 porque o índice do usuário começa em 1
    }

    // Adiciona quantidade ao estoque de um jogo específico
    public void EstoqueEntrada(int posicao, int quantidade)
    {
        if (posicao < 1 || posicao > jogos.Count)
        {
            Console.WriteLine("Posição inválida! O produto não foi encontrado.");
            return;
        }

        jogos[posicao - 1].Estoque += quantidade;
    }

    // Remove quantidade do estoque de um jogo específico
    public void EstoqueSaida(int posicao, int quantidade)
    {
        if (posicao < 1 || posicao > jogos.Count)
        {
            Console.WriteLine("Posição inválida! O produto não foi encontrado.");
            return;
        }

        var jogo = jogos[posicao - 1];
        if (jogo.Estoque < quantidade)
        {
            Console.WriteLine($"Estoque insuficiente! O jogo '{jogo.Nome}' possui apenas {jogo.Estoque} unidades.");
            return;
        }

        jogo.Estoque -= quantidade;
    }
}


