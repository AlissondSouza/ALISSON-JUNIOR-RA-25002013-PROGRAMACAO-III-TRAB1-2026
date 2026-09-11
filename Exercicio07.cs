namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio07
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 7 - CADASTRO E AVALIAÇÃO DE ALUNO ===");

        Aluno aluno = new()
        {
            Nome = Program.LerTexto("Nome: "),
            RA = Program.LerTexto("R.A.: "),
            NotaProva = Program.LerDouble("Nota da prova (0 a 10): ", 0, 10),
            NotaTrabalho = Program.LerDouble("Nota do trabalho (0 a 10): ", 0, 10),
            Frequencia = Program.LerDouble("Frequência (0 a 100%): ", 0, 100)
        };

        double media = aluno.CalcularMedia();
        bool aprovadoFrequencia = aluno.AprovadoPorFrequencia();

        Console.WriteLine("\n--- DADOS DO ALUNO ---");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"R.A.: {aluno.RA}");
        Console.WriteLine($"Nota da prova: {aluno.NotaProva:F1}");
        Console.WriteLine($"Nota do trabalho: {aluno.NotaTrabalho:F1}");
        Console.WriteLine($"Frequência: {aluno.Frequencia:F1}%");
        Console.WriteLine($"Média ponderada: {media:F2}");
        Console.WriteLine($"Situação pela média: {(media >= 7 ? "Aprovado" : "Reprovado")}");
        Console.WriteLine($"Situação pela frequência: {(aprovadoFrequencia ? "Aprovado" : "Reprovado")}");
        Console.WriteLine($"Situação final: {(aluno.Aprovado() ? "APROVADO" : "REPROVADO")}");

        Console.WriteLine("\nRegra de frequência: no máximo 40% de faltas, equivalente a pelo menos 60% de presença.");
        Console.WriteLine("Em 40 aulas, isso representa no máximo 16 faltas e pelo menos 24 presenças.");
    }
}
