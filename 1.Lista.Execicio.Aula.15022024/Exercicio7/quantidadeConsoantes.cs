using System;
using System.Linq;

public class ContagemConsoantes
{
    public static void Executar()
    {
        Console.WriteLine("\nExercício 7: Contagem de Consoantes");
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine().ToLower(); 

        int quantidadeConsoantes = nome.Count(c => "bcdfghjklmnpqrstvwxyz".Contains(c));

        Console.Write($"O nome contém {quantidadeConsoantes} consoantes.");
        Console.WriteLine("");
    }
}
