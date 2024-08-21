using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_CSHARP
{
    public static class Entrada_SaidaDados
    { 
        public static void LerArmazenar()
        {
            string? nome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine($" O Nome é : {nome}");
        }
    }
}
