namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio06
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 6 - CADASTRO DE LIVRO ===");

        Livro livro = new()
        {
            Titulo = Program.LerTexto("Título: "),
            Autor = Program.LerTexto("Autor: "),
            Valor = Program.LerDecimal("Valor: R$ ", 0)
        };

        Console.WriteLine("\n--- LIVRO CADASTRADO ---");
        Console.WriteLine($"Título: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
        Console.WriteLine($"Valor: R$ {livro.Valor:F2}");
    }
}
