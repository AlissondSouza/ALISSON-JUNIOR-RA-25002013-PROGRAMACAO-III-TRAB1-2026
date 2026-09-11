using System.Text;

namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio02
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 2 - QUANTIDADE DE VOGAIS ===");
        string texto = Program.LerTexto("Digite uma frase: ");

        string vogais = "aeiouáàãâéêíóôõúü";
        int quantidade = texto.Count(caractere => vogais.Contains(char.ToLower(caractere)));

        Console.WriteLine($"Quantidade de vogais: {quantidade}");
    }
}
