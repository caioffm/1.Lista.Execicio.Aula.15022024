using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculadora
{
    public static void Executar()
    {
        Console.WriteLine("\nExercício 5: Calculadora com Operações Básicas:");
        Console.Write("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escolha a operação (1 para Soma, 2 paraSubtração, 3 para Multiplicação, 4 paraDivisão, 0 para Resto):");
        string operacao = Console.ReadLine().ToLower();

        switch (operacao)
        {
            case "1":
                Console.Write($"Resultado: {numero1 + numero2}");
                Console.WriteLine("");
                break;
            case "2":
                Console.Write($"Resultado: {numero1 - numero2}");
                Console.WriteLine("");
                break;
            case "3":
                Console.Write($"Resultado: {numero1 * numero2}");
                Console.WriteLine("");
                break;
            case "4":
                if (numero2 != 0)
                    Console.Write($"Resultado: {numero1 / numero2}\n");

                else
                    Console.Write("Divisão por zero não é permitida.");
                break;
            case "0":
                Console.Write($"Resultado: {numero1 % numero2}");

                break;
            default:
                Console.WriteLine("\nOperação inválida.");
                break;
        }
    }
}
