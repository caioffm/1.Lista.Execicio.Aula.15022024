public class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public int TotalFaltas { get; set; }
    public double Media => (NotaProva * 0.7) + (NotaTrabalho * 0.3);
    public double Frequencia => ((25 - TotalFaltas) / 25.0) * 100;
    public string Situacao => (Media >= 7.0 && Frequencia >= 75.0) ? "APROVADO" : "REPROVADO";

    public override string ToString()
    {
        return $"Nome: {Nome}, RA: {RA}, Prova: {NotaProva}, Trabalho: {NotaTrabalho}, Média: {Media:F2}, Faltas: {TotalFaltas}, Frequência: {Frequencia:F2}%, Situação: {Situacao}";
    }
}
