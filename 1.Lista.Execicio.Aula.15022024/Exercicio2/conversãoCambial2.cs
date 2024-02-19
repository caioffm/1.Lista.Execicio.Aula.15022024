using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ConversaoCambial2
{
    public static void Executar()
    {
        double taxaConversao = 5.22;
        Console.WriteLine("\nExercicio 2:onversão cambial entre USD x BRL");
        Console.Write("Digite o valor em BRL que deseja converter para USD: ");
        string valorEmBRLString = Console.ReadLine();
        double valorEmBRL = Convert.ToDouble(valorEmBRLString);
        double valorEmUSD = valorEmBRL * taxaConversao;
        Console.Write($"O valor de {valorEmBRL} USD em BRL é: {valorEmUSD:F2}");
    }
}   