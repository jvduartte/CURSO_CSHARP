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

