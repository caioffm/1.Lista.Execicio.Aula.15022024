using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ConversaoCambial 
{
    public static void Executar()
    {
        double taxaConversao = 0.193259;
        Console.WriteLine("\nExercicio 1:Conversão cambial entre BRL x USD");
        Console.Write("Digite o valor em BRL que deseja converter para USD: ");
        string valorEmBRLString = Console.ReadLine();
        double valorEmBRL = Convert.ToDouble(valorEmBRLString);
        double valorEmUSD = valorEmBRL * taxaConversao;
        Console.WriteLine($"O valor de {valorEmBRL} BRL em USD é: {valorEmUSD:F2}");
    }
}
