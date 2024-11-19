using System.Runtime.CompilerServices;

namespace SENAC_ALG2;

public class Program
{
    static void Main(string[] args)
    {
        GerenciadorJogos ger = new GerenciadorJogos();
        ExibirMenu(ger);
    }

    static void ExibirMenu(GerenciadorJogos ger)
    {
        Console.Clear();
        Console.WriteLine("[1] Novo Jogo");
        Console.WriteLine("[2] Listar Jogos");
        Console.WriteLine("[3] Remover Jogos");
        Console.WriteLine("[4] Entrada Estoque");
        Console.WriteLine("[5] Saída Estoque");
        Console.WriteLine("[0] Sair");

        Console.Write("\nEscolha uma opção: ");
        string opcao = Console.ReadLine(); 

        switch (opcao)
        {
            case "1":
                NovoProduto(ger);
                break;
            case "2":
                ListarProdutos(ger);
                break;
            case "3":
                RemoverProduto(ger);
                break;
            case "4":
                EntradaEstoque(ger);
                break;
            case "5":
                SaidaEstoque(ger);
                break;
            case "0":
                Console.WriteLine("Saindo do programa,desenvolvido por Tatiane Gomes");
                return;
            default:
                Console.WriteLine("Opção inválida! Pressione ENTER para Voltar ao MENU.");
                Console.ReadLine();
                break;
        }

        ExibirMenu(ger); // Chama novamente o menu
    }

    static void NovoProduto(GerenciadorJogos ger)
    {
        Console.Clear();
        Console.Write("Nome do jogo: ");
        string nome = Console.ReadLine();

        Console.Write("Preço do jogo: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Gênero do jogo: ");
        string genero = Console.ReadLine();

        Console.Write("Estoque inicial: ");
        int estoque = int.Parse(Console.ReadLine());

        ger.Adicionar(new Jogo { Nome = nome, Preco = preco, Genero = genero, Estoque = estoque });

        Console.WriteLine("\nProduto adicionado com sucesso! Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    static void ListarProdutos(GerenciadorJogos ger)
    {
        Console.Clear();
        ger.Exibir();
        Console.WriteLine("\nPressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    static void RemoverProduto(GerenciadorJogos ger)
    {
        Console.Clear();
        ger.Exibir();
        Console.Write("\nDigite o número do produto a ser removido: ");
        int posicao = int.Parse(Console.ReadLine());

        ger.Remover(posicao);

        Console.WriteLine("\nProduto removido com sucesso! Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    static void EntradaEstoque(GerenciadorJogos ger)
    {
        Console.Clear();
        ger.Exibir();
        Console.Write("\nDigite o número do produto para entrada de estoque: ");
        int posicao = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade para entrada: ");
        int quantidade = int.Parse(Console.ReadLine());

        ger.EstoqueEntrada(posicao, quantidade);

        Console.WriteLine("\nEstoque atualizado com sucesso! Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    static void SaidaEstoque(GerenciadorJogos ger)
    {
        Console.Clear();
        ger.Exibir();
        Console.Write("\nDigite o número do produto para saída de estoque: ");
        int posicao = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade para saída: ");
        int quantidade = int.Parse(Console.ReadLine());

        ger.EstoqueSaida(posicao, quantidade);

        Console.WriteLine("\nEstoque atualizado com sucesso! Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }
}









    


        
    



