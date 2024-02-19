using System;
using System.Collections.Generic;

public class SistemaEscolar
{
    private List<Aluno> alunos = new List<Aluno>();

    public void Executar()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("           Menu Escolar          ");
            Console.WriteLine("=================================");
            Console.WriteLine("1 - Cadastro de Alunos");
            Console.WriteLine("2 - Cadastro de Notas");
            Console.WriteLine("3 - Cadastro Total de Faltas");
            Console.WriteLine("4 - Relação de Alunos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarAluno();
                    break;
                case 2:
                    CadastrarNotas();
                    break;
                case 3:
                    CadastrarFaltas();
                    break;
                case 4:
                    ListarAlunos();
                    break;
                case 0:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    private void CadastrarAluno()
    {
        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();

        alunos.Add(new Aluno { Nome = nome, RA = ra });
        Console.WriteLine("Aluno cadastrado com sucesso!\n");
    }

    private void CadastrarNotas()
    {
        Console.Write("Digite o RA do aluno para cadastro de notas: ");
        string ra = Console.ReadLine();

        var aluno = alunos.Find(a => a.RA == ra);
        if (aluno != null)
        {
            Console.Write("Digite a nota da prova (0 a 10): ");
            aluno.NotaProva = Math.Max(0, Math.Min(10, Convert.ToDouble(Console.ReadLine())));

            Console.Write("Digite a nota do trabalho (0 a 10): ");
            aluno.NotaTrabalho = Math.Max(0, Math.Min(10, Convert.ToDouble(Console.ReadLine())));

            Console.WriteLine("Notas cadastradas com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.\n");
        }
    }

    private void CadastrarFaltas()
    {
        Console.Write("Digite o RA do aluno para cadastro de faltas: ");
        string ra = Console.ReadLine();

        var aluno = alunos.Find(a => a.RA == ra);
        if (aluno != null)
        {
            Console.Write("Digite o total de faltas do aluno: ");
            aluno.TotalFaltas = Math.Max(0, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Faltas cadastradas com sucesso!\n");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.\n");
        }
    }

    private void ListarAlunos()
    {
        Console.WriteLine("Relação de Alunos:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
        Console.WriteLine();
    }
}
