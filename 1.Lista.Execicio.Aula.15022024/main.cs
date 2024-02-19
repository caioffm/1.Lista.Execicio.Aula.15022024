using System;

class MenuPrincipal
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
             
            Console.WriteLine("=================================");
            Console.WriteLine("           Menu Principal        ");
            Console.WriteLine("=================================");
            Console.WriteLine("1 - Exercicio 1: Conversão cambial entre BRL x USD");
            Console.WriteLine("2 - Exercicio 2: Conversão cambial entre USD x BRL");
            Console.WriteLine("3 - Exercício 3: Calculo da Média de Gasto de um Automóvel");
            Console.WriteLine("4 - Exercício 4: Calculo da Idade");
            Console.WriteLine("5 - Exercício 5: Calculadora Simples");
            Console.WriteLine("6 - Exercício 6: Contagem de Vogais");
            Console.WriteLine("7 - Exercício 7: Contagem de Consoantes");
            Console.WriteLine("8 - Exercício 8: Classificação por Faixa Etária");
            Console.WriteLine("9 - Exercício 9: Cadastro de Livros com Struct");
            Console.WriteLine("10 -Exercício 10: Cadastro de Alunos e Notas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=================================");
            Console.Write("Escolha uma opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)            {
                case 0:
                    continuar = false;
                    break;
                case 1:
                    ConversaoCambial.Executar(); 
                    break;
                case 2:
                    ConversaoCambial2.Executar();
                    break;
                case 3:
                    CalculoMediaGastoAutomovel.Executar();
                    break;
                case 4:
                    CalculoIdade.Executar();
                    break;
                case 5:
                    Calculadora.Executar();
                    break;
                case 6:
                    ContagemVogais.Executar();
                    break;
                case 7:
                    ContagemConsoantes.Executar();
                    break;
                case 8:
                    ClassificacaoFaixaEtaria.Executar();
                    break;
                case 9:
                    CadastroLivro.Executar();
                    break;
                case 10:
                    var sistemaEscolar = new SistemaEscolar();
                    sistemaEscolar.Executar();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
        }
    }
}
