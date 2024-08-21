using CURSO_CSHARP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;


/*
 
namespace CURSO_CSHARP
{
public static class Entrada_SaidaDados
{
    public static void entradasaida()
    {
        string? nome;
        string? sobrenome
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine($" O Nome é : {nome}");
        sobrenome = Console.ReadLine();
        Console.WriteLine($"Sobrenome é: ");
    }
}
}
*/

/*
namespace CURSO_CSHARP
{
    public static class Entrada_SaidaDados
    {
        public static void entradasaida()
        {
            string? nome;
            int? idade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine($" O Nome é : {nome}");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A idade é:");
        }
    }
}
*/


/*
namespace CURSO_CSHARP
{
    public static class Entrada_SaidaDados
    {
        public static void entradasaida()
        {
            string? nome;
            string? cidade;
            Console.WriteLine("Digite o nome da cidade:");
            nome = Console.ReadLine();

            Console.WriteLine($" O Nome é : {nome}");
            cidade = Console.ReadLine();
            Console.WriteLine($"A cidade é: ");
        }
    }
}
*/


/*
namespace CURSO_CSHARP
{
    public static class ExercicioTiposPrimitivos
    {
        public static void entradasaida()
        {
            string? nome;
           
            Console.WriteLine($"Digite o seu nome:");
            nome = Console.ReadLine().ToUpper();
            Console.WriteLine();

         
        }
    }
}

*/


/**
namespace CURSO_CSHARP
{
    public static class ExercicioTiposPrimitivos
    {
        public static void entradasaida()
        {
            string? nome;

            Console.WriteLine($"Digite o seu nome:");
            nome = Console.ReadLine().ToLower();
            Console.WriteLine();


        }
    }
}


*/

/*
namespace CURSO_CSHARP
{
    public static class ExercicioTiposPrimitivos
    {
        public static void entradasaida()
        {
            string? nome;
            int? idade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O nome é:{nome}, á idade é:{idade}");

        }
    }
}
*/


/*
namespace CURSO_CSHARP
{
    public static class ExercicioTiposPrimitivos
    {
        public static void entradasaida()
        {
            string? nome, cidade;
            int? nascimento;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine($"Digite sua cidade:");
            cidade = Console.ReadLine();
            Console.WriteLine($"Nascido em?: ");
            nascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O nome é: {nome}, cidade é: {cidade}, nascido em: {nascimento}");
          
        }
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, profissão;
        
        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite sua profissão:");
        profissão = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, sua profissão é: {profissão} ");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, país;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite sua profissão:");
        país = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, sua profissão é: {país} ");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, hobby;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite seu hobby:");
        hobby = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, seu hobby é: {hobby} ");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, cor;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite sua profissão:");
        cor = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, sua profissão é: {cor} ");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, filme;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite sua profissão:");
        filme= Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, sua profissão é: {filme} ");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, número;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite seu número:");
        número = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, seu número favorito é: {número} ");
    }
}
*/



/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, profissão;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite sua profissão:");
        profissão = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, sua profissão é: {profissão} ");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, animal;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite seu animal:");
        animal= Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, seu animal favorito é: {animal} ");
    }
}
*/

/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, musíca;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite seu cantor:");
        musíca = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, sua musíca favorita é: {musíca} ");
    }
}

*/

/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        string? nome, livro;

        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Digite seu livro:");
      livro = Console.ReadLine();
        Console.WriteLine($"Seu nome é: {nome}, seu  livro favorito é: {livro} ");
    }
}
*/




/* Exercico 2 */

/*

### Questões de Múltipla Escolha
1.Qual é o operador para multiplicação em C#?

   - c) *

2. Qual é o resultado da expressão 7 % 3 em C#?




public static class ExercicioTiposPrimitivos
{
    puiblic static void entradasaida()
    {
        int resultado = 7 % 3;
        Console.WriteLine("O resultado de 7 % 3 é: " + resultado);
    }
}

   

3. Qual operador é utilizado para divisão em C#?

   - a) /


4. O que a expressão 5 / 2 retorna em C#?




public static class ExercicioTiposPrimitivos
{
    puiblic static void entradasaida()
    {
        int resultado = 5 / 2;
        Console.WriteLine("O resultado de 5 / 2 é: " + resultado);
    }
}
  




5. Qual é o resultado da operação 10 - 4?



public static class ExercicioTiposPrimitivos
{
    puiblic static void entradasaida()
    {
        int resultado = 10 - 4;
        Console.WriteLine("O resultado de 10 - 4 é: " + resultado);
    }
}



 

6. Como é representado o operador de incremento em C#?

   - b) ++

7. Qual é o efeito do operador n++ em C#?

   - b) Incrementa n depois de usá-lo

8. Qual operador realiza a subtração em C#?
]
   - d) -

9. O que a expressão 6 * 3 retorna em C#?

  

public static class ExercicioTiposPrimitivos
{
     public static void entradasaida()
    {
        int resultado = 6 * 3;
        Console.WriteLine("O resultado de 6 * 3 é: " + resultado);
    }
}


10. O operador de decremento em C# é representado por qual símbolo?

    - b) --

### Questões de Verdadeiro ou Falso


11. A operação 5 % 3 em C# retorna 3.

using System;

class Program
{
    static void Main()
    {
        int resultado = 5 % 3;
        Console.WriteLine("O resultado de 5 % 3 é: " + resultado);
    }
}


    - b) Falso



12. A expressão 7 + 2 resulta em 9 em C#.



using System;

class Program
{
    static void Main()
    {
        int resultado = 7 + 2;
        Console.WriteLine("7 + 2 = " + resultado);
        Console.WriteLine("A expressão 7 + 2 resulta em 9? " + (resultado == 9));
    }
}


    - a) Verdadeiro

13. O operador ++n incrementa o valor de n antes da operação.
    - a) Verdadeiro

14. O operador n-- decrementa o valor de n depois da operação.
    - a) Verdadeiro

15. O operador % calcula o resto da divisão entre dois números.
    - a) Verdadeiro

### Questões de Preenchimento de Lacunas

16. Para calcular o resto da divisão entre dois números em C#, você deve usar o operador **%**.

17. O operador para divisão em C# é /

18. Para somar dois números em C#, você usa o operador **+**.

19. A expressão 4 * 5 retorna 20 em C#.

20. O operador -- é utilizado para **decrementar**.

*/




/* Exercico 3° */


/*

public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        // Solicita ao usuário o primeiro número
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Solicita ao usuário o segundo número
        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Calcula a soma dos dois números
        int soma = numero1 + numero2;

        // Exibe o resultado
        Console.WriteLine("A soma dos dois números é: " + soma);
    }
}

*/



/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir o primeiro número
        Console.Write("Insira o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Solicita ao usuário para inserir o segundo número
        Console.Write("Insira o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Calcula a diferença entre o primeiro e o segundo número
        int diferenca = numero1 - numero2;

        // Exibe o resultado com uma mensagem
        Console.WriteLine($"A diferença entre {numero1} e {numero2} é {diferenca}.");
    }
}

*/


/*
public static class ExercicioTiposPrimitivos

{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir o primeiro número
        Console.Write("Insira o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Solicita ao usuário para inserir o segundo número
        Console.Write("Insira o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Calcula a multiplicação dos dois números
        int multiplicacao = numero1 * numero2;

        // Exibe o resultado com uma mensagem
        Console.WriteLine($"A multiplicação de {numero1} e {numero2} é {multiplicacao}.");
    }
}

*/


/*
public static class ExercicioTiposPrimitivos

{
   public static void entradasaida()
    {
            // Solicita ao usuário para inserir o primeiro número
            Console.Write("Insira o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita ao usuário para inserir o segundo número
            Console.Write("Insira o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Verifica se o segundo número é zero para evitar divisão por zero
            if (numero2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            else
            {
                // Calcula a divisão do primeiro número pelo segundo
                double divisao = (double)numero1 / numero2;

                // Exibe o resultado com uma mensagem
                Console.WriteLine($"A divisão de {numero1} por {numero2} é {divisao}.");
            }
        }
    }

*/


/*
public static class ExercicioTiposPrimitivos

{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir o primeiro número
        Console.Write("Insira o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Solicita ao usuário para inserir o segundo número
        Console.Write("Insira o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Calcula o resto da divisão do primeiro número pelo segundo
        int resto = numero1 % numero2;

        // Exibe o resultado com uma mensagem
        Console.WriteLine($"O resto da divisão de {numero1} por {numero2} é {resto}.");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos

{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir um número inteiro
        Console.Write("Insira um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Incrementa o número em 1
        numero++;

        // Exibe o resultado com uma mensagem
        Console.WriteLine($"O número incrementado em 1 é {numero}.");
    }
}

*/


/*
public static class ExercicioTiposPrimitivos 
{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir um número inteiro
        Console.Write("Insira um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Decrementa o número em 1
        numero--;

        // Exibe o resultado com uma mensagem
        Console.WriteLine($"O número decrementado em 1 é {numero}.");
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir o primeiro número
        Console.Write("Insira o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Solicita ao usuário para inserir o segundo número
        Console.Write("Insira o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Calcula a média dos dois números
        double media = (numero1 + numero2) / 2.0;

        // Exibe o resultado com uma mensagem informativa
        Console.WriteLine($"A média de {numero1} e {numero2} é {media}.");
    }
}
*/

/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        // Solicita os três números inteiros ao usuário
        Console.Write("Insira o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o terceiro número: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Calcula a soma dos dois primeiros números
        int soma = num1 + num2;

        // Subtrai o terceiro número do resultado da soma
        int resultado = soma - num3;

        // Exibe o resultado com uma mensagem explicativa
        Console.WriteLine("A soma dos dois primeiros números é: " + soma);
        Console.WriteLine("Subtraindo o terceiro número, o resultado final é: " + resultado);
    }
}
*/


/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        // Solicita ao usuário para inserir um valor
        Console.Write("Insira um valor: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        // Calcula o dobro e a metade do valor
        double dobro = valor * 2;
        double metade = valor / 2;

        // Exibe o resultado com mensagens explicativas
        Console.WriteLine("O dobro do valor é: " + dobro);
        Console.WriteLine("A metade do valor é: " + metade);
    }
}
*/



/*
public static class ExercicioTiposPrimitivos
{
    public static void entradasaida()
    {
        // Solicita os dois números inteiros ao usuário
        Console.Write("Insira o primeiro número (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo número (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Calcula o resultado da expressão (a + b) * (a - b)
        int resultado = (a + b) * (a - b);

        // Exibe o resultado com uma mensagem informativa
        Console.WriteLine("O resultado da expressão (a + b) * (a - b) é: " + resultado);
    }
}
*/




/*Arrays
1. Criando e Inicializando um Array
Crie um array de inteiros chamado numeros com capacidade para 5 elementos.
Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.*/


/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        int[] numeros = {2,4,6,8,10};
        foreach (int n in numeros)
            Console.WriteLine(n);
    }
}



/*2. Acessando Elementos de um Array
Dado o array int[] valores = { 1, 3, 5, 7, 9};, imprima o terceiro
elemento do array.*/

/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        int[] numeros = {1,3,5,7,9};
        Console.WriteLine($"{numeros [3] }");
    }
}
*/







/*3. Alterando Valores em um Array
Crie um array de strings chamado nomes com os valores &quot; Ana & quot;, &quot; Bruno & quot;,
&quot; Carla & quot;. Mude o valor de &quot; Bruno & quot; para & quot; Beto & quot; e depois imprima todos os
elementos do array.


/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        string[] nomes = {"Ana", "Bruno", "Carla"};
        for (int i = 0; i < nomes.Length; i++) 
        {
            if (nomes[i] == "Bruno") 
            {
                nomes[i] = "Beto";

                Console.WriteLine(nomes[i]);
            }
            
        }
    }
}








/*4. Calculando a Soma dos Elementos de um Array
Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6.
Calcule e imprima a soma de todos os elementos do array.*/


/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        int[] valores = { 7, 8, 9, 10, 6 };
        int soma = 0;
        for (int i = 0; i < valores.Length; i++) 
        {
            soma = soma + valores[i];

        }
        Console.WriteLine($"A soma de todos os valores {soma}.");   
    }
}







/*5. Procurando um Elemento em um Array
Dado o array int[] numeros = { 5, 10, 15, 20, 25};, escreva um código
que verifique se o número 15 está presente no array e imprima uma mensagem
confirmando.*/


/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        int[] numeros = { 5, 10, 15, 20, 25 };
        int numero15 = 15;
        bool encontrado = false;

        foreach (int numero in numeros)
        {
            if (numero == numero15)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine($"O número {numero15} está presente no array.");
        }
        else
        {
            Console.WriteLine($"O número  {numero15} não está presente no array.");
        }
    }
}
*/




/*List
1. Criando e Adicionando Elementos em uma List
Crie uma List&lt; string&gt; chamada frutas. Adicione as frutas & quot; Maçã & quot;,
&quot; Banana & quot;, &quot; Laranja & quot; e imprima todos os elementos da lista.*/


/*
public static class Exercicios
{
    public static void MetodoExe()
    {
       List<string> frutas = new List<string>() {"Maçã", "Banana", "Laranja" };
        foreach (string f in frutas) 
        {
            Console.WriteLine(f);
        }
    }
}






/*
2. Removendo um Elemento de uma List
Crie uma List&lt; int&gt; chamada numeros e adicione os valores 1, 2, 3, 4, 5.
Remova o número 3 da lista e depois imprima os elementos restantes.*/

/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        List<int> intnumeros = new List<int>() {1,2,3,4,5 };
        intnumeros.RemoveAt(2); 
        Console.WriteLine("\nLista de numeros após remoções:");
        foreach (int i in intnumeros) 
        {
            Console.WriteLine(i);
        }
    }
}





/*
3. Acessando um Elemento Específico em uma List
Dada a List&lt; string&gt; chamada cidades = new List& lt; string&gt;
{
    &quot; São
Paulo & quot;, &quot; Rio de Janeiro & quot;, &quot; Belo Horizonte&quot;
}, imprima a segunda
cidade da lista.*/


/*
public static class Exercicios
{
    public static void MetodoExe()
    {
        List<string> cidades = new List<string>() { "São Paulo", "Rio de Janeiro", "Belorizonte" };
        {
            Console.WriteLine( cidades[1]);
        }
    }
}



/*
4. Contando Elementos em uma List
Crie uma List&lt; string&gt; chamada animais e adicione os valores &quot; Cachorro & quot;,
&quot; Gato & quot;, &quot; Coelho & quot;. Escreva um código que imprima quantos elementos
existem na lista.*/

/*
public static class Exercicios
{
    public static void MetodoExe()
    {
    List<string> animais = new List<string>() {"Cachorro", "Coelho", "Gato"};
    Console.WriteLine("Número de elementos na lista 'animais': " + animais.Count);
    }
    
}
*/



/*
Escopo de Variáveis
1. Variável Local em um Método
Escreva um método chamado CalculaSoma que declare uma variável local int
soma e calcule a soma de dois números passados como parâmetros. A variável
soma deve estar acessível apenas dentro deste método.*/



    

   










/*
2. Variável Global em uma Classe
Crie uma classe chamada Carro com uma variável global string marca. No
método Main, instancie um objeto Carro, defina a marca do carro como
&quot; Toyota & quot; e imprima a marca.*/











/*
3. Conflito de Escopo
Escreva um método onde você declare uma variável local com o mesmo nome

de uma variável global da classe. Mostre como acessar ambas as variáveis no
mesmo método.*/







/*
4. Variável Local dentro de um Bloco Condicional
Escreva um código onde uma variável int x seja declarada dentro de um bloco
if. Tente acessar essa variável fora do bloco if e observe o que acontece.*/








/*
5. Alterando o Valor de uma Variável Global
Crie uma variável global int contador em uma classe. No método Main, altere
o valor de contador dentro de um loop for e depois imprima o valor final de
contador.*/



/*
6.  Capturando uma Exceção de Conversão de Tipo
Tente converter uma string não numérica para um inteiro usando int.Parse.
Use try-catch para capturar a exceção e imprima uma mensagem apropriada.*/




/*
7.  Lançando Exceções
Escreva um método que recebe um número inteiro. Se o número for negativo,
lance uma ArgumentException. Capture a exceção no método Main e imprima
uma mensagem apropriada.*/