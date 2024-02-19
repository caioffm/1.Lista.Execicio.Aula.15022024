using System;

public class CadastroLivro
{
    struct Livro
    {
        public string Titulo;
        public string Autor;
        public decimal Valor;

        public Livro(string titulo, string autor, decimal valor)
        {
            Titulo = titulo;
            Autor = autor;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Valor: R${Valor:F2}";
        }
    }

    public static void Executar()
    {
        Console.WriteLine("\nExercício 9: Cadastro de Livro com Struct");
        Console.Write("Digite o título do livro:");
        string titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro:");
        string autor = Console.ReadLine();

        Console.Write("Digite o valor do livro:");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Livro novoLivro = new Livro(titulo, autor, valor);

        Console.WriteLine(novoLivro.ToString());
        Console.WriteLine("");
    }
}
