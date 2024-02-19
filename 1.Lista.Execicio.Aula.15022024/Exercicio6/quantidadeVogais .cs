using System;
using System.Linq;

public class ContagemVogais
{
    public static void Executar()
    {
        Console.WriteLine("\nExercício 6: Contagem de Vogais");
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine().ToLower();
        int quantidadeVogais = nome.Count(c => "aeiou".Contains(c));

        Console.Write($"O nome contém {quantidadeVogais} vogais.");
        Console.WriteLine("");
    }
}
