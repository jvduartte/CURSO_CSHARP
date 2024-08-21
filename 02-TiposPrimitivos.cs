using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_CSHARP
{
    public static class TiposPrimitivos
    {
        public static void ImprimirTipos()
        {

            sbyte SByte = -128; //Valores Variam de -128 a 127
            Console.WriteLine($"SByte: {SByte} ");

            byte variavelByte = 255; //Valores Variam de 0 a 255
            Console.WriteLine($"byte: {variavelByte}");

            short variavelShort = -32768; //Valores Variam de -32768 a 32767
            Console.WriteLine($"short: {variavelShort}");

            ushort variavelUShort = 65535; //Valores Variam de 0 a 65535
            Console.WriteLine($"ushort: {variavelUShort}");

            int variavelInt = -2147483648; //Valores Variam de -2147483648 a 2147483647
            Console.WriteLine($"int: {variavelInt}");

            uint variavelUInt = 4294967295; //Valores Variam de 0 a 4294967295
            Console.WriteLine($"uint: {variavelUInt}");

            long variavelLong = -9223372036854775808; //Valores Variam de -9223372036854775808 a 9223372036854775807
            Console.WriteLine($"long: {variavelLong}");

            float variavelFloat = 3.14f; 
            Console.WriteLine($"float: {variavelFloat}");

            double variavelDouble = 3.141592653589793;
            Console.WriteLine($"double: {variavelDouble}");

            decimal variavelDecimal = 79228162514264337593543950335M;
            Console.WriteLine($"decimal: {variavelDecimal}");

            char variavelChar = 'A';
            Console.WriteLine($"char: {variavelChar}");

            bool variavelBool = true;
            Console.WriteLine($"bool: {variavelBool}");

            object variavelObject = null;
            Console.WriteLine($"object: {variavelObject}");

            string variavelString = "Olá, Mundo!";
            Console.WriteLine($"string: {variavelString}");


        }

    }
    
}

/**
 * sbyte SByte = -128; // Valores variam de -128 a 127
Console.WriteLine($"SByte: {SByte}");

byte variavelByte = 255; // Valores variam de 0 a 255
Console.WriteLine($"byte: {variavelByte}");

short variavelShort = -32768; // Valores variam de -32768 a 32767
Console.WriteLine($"short: {variavelShort}");

ushort variavelUShort = 65535; // Valores variam de 0 a 65535
Console.WriteLine($"ushort: {variavelUShort}");

int variavelInt = -2147483648; // Valores variam de -2147483648 a 2147483647
Console.WriteLine($"int: {variavelInt}");

uint variavelUInt = 4294967295; // Valores variam de 0 a 4294967295
Console.WriteLine($"uint: {variavelUInt}");

long variavelLong = -9223372036854775808; // Valores variam de -9223372036854775808 a 9223372036854775807
Console.WriteLine($"long: {variavelLong}");

float variavelFloat = 3.14f;
Console.WriteLine($"float: {variavelFloat}");

double variavelDouble = 3.141592653589793;
Console.WriteLine($"double: {variavelDouble}");

decimal variavelDecimal = 79228162514264337593543950335M;
Console.WriteLine($"decimal: {variavelDecimal}");

char variavelChar = 'A';
Console.WriteLine($"char: {variavelChar}");

bool variavelBool = true;
Console.WriteLine($"bool: {variavelBool}");

object variavelObject = null;
Console.WriteLine($"object: {variavelObject}");

string variavelString = "Olá, Mundo!";
Console.WriteLine($"string: {variavelString}"); /*


/*Claro! Vou adicionar comentários ao seu código para explicar cada parte:

```csharp
sbyte SByte = -128; // Valores variam de -128 a 127
Console.WriteLine($"SByte: {SByte}");

byte variavelByte = 255; // Valores variam de 0 a 255
Console.WriteLine($"byte: {variavelByte}");

short variavelShort = -32768; // Valores variam de -32768 a 32767
Console.WriteLine($"short: {variavelShort}");

ushort variavelUShort = 65535; // Valores variam de 0 a 65535
Console.WriteLine($"ushort: {variavelUShort}");

int variavelInt = -2147483648; // Valores variam de -2147483648 a 2147483647
Console.WriteLine($"int: {variavelInt}");

uint variavelUInt = 4294967295; // Valores variam de 0 a 4294967295
Console.WriteLine($"uint: {variavelUInt}");

long variavelLong = -9223372036854775808; // Valores variam de -9223372036854775808 a 9223372036854775807
Console.WriteLine($"long: {variavelLong}");

float variavelFloat = 3.14f;
Console.WriteLine($"float: {variavelFloat}");

double variavelDouble = 3.141592653589793;
Console.WriteLine($"double: {variavelDouble}");

decimal variavelDecimal = 79228162514264337593543950335M;
Console.WriteLine($"decimal: {variavelDecimal}");

char variavelChar = 'A';
Console.WriteLine($"char: {variavelChar}");

bool variavelBool = true;
Console.WriteLine($"bool: {variavelBool}");

object variavelObject = null;
Console.WriteLine($"object: {variavelObject}");

string variavelString = "Olá, Mundo!";
Console.WriteLine($"string: {variavelString}");
```

Aqui estão os comentários explicando cada linha:

- `sbyte`: É um tipo de dado numérico que representa inteiros de 8 bits com sinal. O valor mínimo é -128 e o máximo é 127.
- `byte`: Também é um tipo de dado numérico de 8 bits, mas sem sinal. Os valores variam de 0 a 255.
- `short`: Representa inteiros de 16 bits com sinal. O menor valor é -32768 e o maior é 32767.
- `ushort`: Similar ao `short`, mas sem sinal. Os valores variam de 0 a 65535.
- `int`: É um tipo de dado de 32 bits para inteiros com sinal. O menor valor é -2147483648 e o maior é 2147483647.
- `uint`: Semelhante ao `int`, mas sem sinal. Os valores variam de 0 a 4294967295.
- `long`: Representa inteiros de 64 bits com sinal. O menor valor é -9223372036854775808 e o maior é 9223372036854775807.
- `float`: É um tipo de ponto flutuante de 32 bits usado para representar números reais. O valor que você declarou (3.14f) é um exemplo de float.
- `double`: Também é um tipo de ponto flutuante, mas com 64 bits. O valor que você declarou (3.141592653589793) é um exemplo de double.
- `decimal`: É usado para representar números decimais com alta precisão. O valor que você declarou (79228162514264337593543950335M) é um exemplo de decimal.
- `char`: Representa um único caractere Unicode. O valor que você declarou ('A') é um exemplo de char.
- `bool`: Representa valores booleanos (verdadeiro ou falso). O valor que você declarou (true) é um exemplo de bool.
- `object`: É um tipo especial que pode conter qualquer valor. O valor que você declarou (null) indica que a variável não está apontando para nenhum objeto.
- `string`: Representa uma sequência de caracteres. O valor que você declarou ("Olá, Mundo!") é um exemplo de string.

Se precisar de mais esclarecimentos ou tiver outras perguntas, estou à disposição! 😊   
 * */
