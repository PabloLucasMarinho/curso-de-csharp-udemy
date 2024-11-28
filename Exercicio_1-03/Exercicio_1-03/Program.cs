using Exercicio_1_03;
using System.Globalization;

string opcao;

Console.Write("Digite o nome do produto: ");
string nome = Console.ReadLine();

Console.Write("Digite o preço do produto: R$");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite a quantidade em estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto produto = new Produto(nome, preco, quantidade);

/*Produto produto = new Produto
{
    Nome = "TV",
    Preco = 500.00,
    Quantidade = 20
};*/

Console.WriteLine("---------------------------");
Console.WriteLine("Dados do produto: " + produto);
Console.WriteLine("---------------------------");

do
{
    Console.WriteLine("Digite [SAIR] para encerrar o programa.");
    Console.Write("Digite [ADD] para Aumentar a quantidade do produto ou [REMOVE] para Diminuir a quantidade: ");
    opcao = Console.ReadLine().ToUpper();
    switch (opcao)
    {
        case "ADD":
            Console.Write("Digite a quantidade que deseja somar: ");
            produto.AdicionarProdutos(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine("---------------------------");
            break;
        case "REMOVE":
            Console.Write("Digite a quantidade que deseja subtrair: ");
            produto.RemoverProdutos(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine("---------------------------");
            break;
    }
}
while (opcao != "SAIR");
Console.WriteLine("PROGRAMA ENCERRADO!");