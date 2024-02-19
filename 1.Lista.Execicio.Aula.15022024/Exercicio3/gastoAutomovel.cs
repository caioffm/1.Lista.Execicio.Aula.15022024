using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculoMediaGastoAutomovel
{
    public static void Executar()
    {
        Console.WriteLine("\nExercício 3: Cálculo da Média de Gasto de um Automóvel");
        Console.Write("Digite a distância total percorrida em KM:");
        double distanciaKm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o total de combustível gasto em Litros:");
        double gastoCombustivelLts = Convert.ToDouble(Console.ReadLine());

        double mediaConsumo = distanciaKm / gastoCombustivelLts;

        Console.Write($"A média de consumo do automóvel é: {mediaConsumo:F2} KM/L");
    }
}
