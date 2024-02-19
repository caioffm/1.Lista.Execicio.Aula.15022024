using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculoIdade
{
    public static void Executar()
    {
        Console.WriteLine("\nExercício 4: Cálculo da Idade.");
        Console.Write("Digite o seu ano de nascimento:");
        int anoNascimento = Convert.ToInt32(Console.ReadLine());
        int anoAtual = DateTime.Now.Year;
        int idade = anoAtual - anoNascimento;

        Console.Write($"Sua idade é: {idade} anos.");
    }
}