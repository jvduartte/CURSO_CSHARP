// See https://aka.ms/new-console-template for more information

using CURSO_CSHARP;
using System;
using System.Runtime.Remoting;

//bool resultado;
//resultado =  _04_OperadoresLogicos.ELogico(false, false);
//Console.WriteLine($"O resultado do operador logico E:{resultado}");
//resultado = _04_OperadoresLogicos.Negacao(true);
//Console.WriteLine($"O resultado do operador logico Negação:{resultado}");
//resultado = _04_OperadoresLogicos.OULogico(true, true);
//Console.WriteLine($"O resultado do operador logico OuLogico:{resultado}");
//resultado = _04_OperadoresLogicos.OUExclusivo(false, false);
//Console.WriteLine($"O resultado do operador logico OUExclusivo:{resultado}");

//EntradaSaidaDadoss.LerArmazenar();    
//ExercicioTiposPrimitivos.EntradaSaida();
//OperadoresAritmeticos.Soma();
//OperadoresAritmeticos.Subtracao();
//OperadoresAritmeticos.Multiplicacao();
//OperadoresAritmeticos.Divisao();
//OperadoresAritmeticos.Resto();
//OperadoresAritmeticos.Incremento();
//OperadoresAritmeticos.Decremento();
//OperadoresComparacao.DemonstrarOperadores();
//Exercicio.MostrarResultado();
//Conversao.DemonstrarConversoes();
//EstruturaRepeticao.DemonstrarRepeticoes();
//_07_OperadorTernario.DemonstrarTernario();
//Conversao.DemonstrarConversoes();
//_9_EstruturaCondicional.DemonstrarCondicionais();
//ArrayExemplo.DemonstrarArray();
//ListExemplo.DemonstrarLista();

/*
Aluno vitor = new Aluno();
Aluno atila = new Aluno();

vitor.nome = "João Vitor";
vitor.matricula = "5023";
vitor.curso = "tecnico";

atila.nome = "Atila Cantoara";
atila.matricula = "2301";
atila.curso = "Tecnico";

Console.WriteLine($"O nome do Aluno é: {vitor.nome}, sua matricula é; {vitor.matricula}, faz curso: {vitor.curso}.");
Console.WriteLine($"O nome do Aluno é: {atila.nome}, sua matricula é; {atila.matricula}, faz curso: {atila.curso}.");
*/

/*EscopoVariavel es = new EscopoVariavel();
es.Metodo1();
es.Metodo2();
es.Metodo3();
es.ExibirContadorGlobal();
*/


/*TrataExcecoes tr = new TrataExcecoes();
tr.ExecutarDivisao(9, 3);
TrataExcecoes tr1 = new TrataExcecoes();

tr1.ExecutarDivisao(7, 0);
*/

//Exercicios.MetodoExe();

/*ConceitosPOO OB = new ConceitosPOO();
// Exolicar Orientção a Obejetos
OB.ExplicarOrientacaoAObjetos();
//Explicar a diferença entre Progrmação Estruturada e Orientada  Objeto
OB.DiferencaEntreParadigmas();
// Explicar os Pilares da Orientação a Objeto
OB.ExplicarPilares();*/


/*
Pessoa pessoa1 = new Pessoa("Alice", 30);
Pessoa pessoa2 = new Pessoa("Bob", 40);

// 2- Usando Métodos de Instância (Métodos não estáticos).
pessoa1.ExibirInformacoes();
pessoa2.ExibirInformacoes();

// 3- Usando Métodos Estático (Pertecen á Classe, não á instância).

Pessoa.ExibirNumeroDePessoas();

// 4 - Métodos de Instância VS. Membros Estáticos.

Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");
*/


/*using static CURSO_CSHARP._18_Encapsulamento;

// Instanciando a classe Produto usando o construtor padrão
Produto produto1 = new Produto();
produto1.ExibirInformacoes();

// Instanciando a classe Produto usando o construtor com parâmetros
Produto produto2 = new Produto("Smartphone", 1999.99m, 50);
produto2.ExibirInformacoes();

// Modificando atributos usando propriedades
produto1.Nome = "Notebook";
produto1.Preco = 2999.99m;
produto1.Estoque = 25;
produto1.ExibirInformacoes();

// Acessando método protegido através da classe derivada
ProdutoEspecial produtoEspecial = new ProdutoEspecial();
produtoEspecial.ExibirMetodoProtegido();*/


/*var example = new VarUsageExample();
example.DemonstrateVarUsage();*/

/*var examplo = new ExemploUsoDynamic();
examplo.DemonstrarUsoDynamic();*/

/*var examplo = new ExemploUsoLINQ();
examplo.DemonstrarUsoLINQ();*/

/*var example = new ExerciciosVar();
example.ExebirVar();*/


/*var examplo = new ExeLINQ();
examplo.ExebirLINQ();*/


/*var pessoa = new Pessoa("João", 30);
pessoa.Apresentar();
*/



/*
    
        List<Pessoa28> pessoas = new List<Pessoa28>
            {
                new Pessoa28 { Nome = "Ana", Idade = 30 },
                new Pessoa28 { Nome = "Carlos", Idade = 40 },
                new Pessoa28 { Nome = "Amanda", Idade = 22 },
                new Pessoa28 { Nome = "Arthur", Idade = 28 }
            };

        var resultado = from pessoa in pessoas
                        where pessoa.Nome.StartsWith("A") && pessoa.Idade > 25
                        select pessoa.Nome;

        foreach (var nome in resultado)
        {
    Console.WriteLine(nome);
        }
    */




/*
var explicacaoEnum = new ExplicacaoEnum();

explicacaoEnum.DemonstrarEnum();

explicacaoEnum.ExplicacaoDetalhada();*/

/*
var explicacao = new ExplicacaoStructs();
explicacao.DemonstrarDiferenca();*/


using System;
using System.Collections.Generic;

namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }
}

