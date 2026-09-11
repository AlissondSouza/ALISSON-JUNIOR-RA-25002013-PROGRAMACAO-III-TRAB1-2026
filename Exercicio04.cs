namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio04
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 4 - APENAS CONSOANTES ===");
        string texto = Program.LerTexto("Digite uma frase: ");
        const string vogais = "aeiouáàãâéêíóôõúü";

        string resultado = new(texto
            .Where(char.IsLetter)
            .Where(caractere => !vogais.Contains(char.ToLower(caractere)))
            .ToArray());

        Console.WriteLine($"Consoantes: {resultado}");
    }
}
