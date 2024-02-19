using System;

public class ClassificacaoFaixaEtaria
{
    public static void Executar()
    {
        Console.WriteLine("\nExercício 8: Classificação por Faixa Etária");
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.Write("Digite sua data de nascimento (formato DD/MM/AAAA):");
        DateTime dataNascimento;
        if (DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            string faixaEtaria = idade <= 19 ? "Jovem" :
                                 idade <= 59 ? "Adulto" : "Idoso";

            Console.Write($"{nome}, você está na faixa etária: {faixaEtaria}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Data de nascimento inválida.");
            Console.WriteLine("");
        }
    }
}
