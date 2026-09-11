namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio03
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 3 - APENAS VOGAIS ===");
        string texto = Program.LerTexto("Digite uma frase: ");
        string vogais = "aeiouáàãâéêíóôõúü";

        string resultado = new(texto.Where(caractere => vogais.Contains(char.ToLower(caractere))).ToArray());
        Console.WriteLine($"Vogais: {resultado}");
    }
}
