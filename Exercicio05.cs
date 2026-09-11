namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio05
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 5 - FAIXA ETÁRIA ===");
        int idade = Program.LerInteiro("Digite a idade: ");

        if (idade < 0)
        {
            Console.WriteLine("Idade inválida.");
            return;
        }

        if (idade <= 19)
            Console.WriteLine("Faixa etária: Jovem");
        else if (idade <= 59)
            Console.WriteLine("Faixa etária: Adulto");
        else
            Console.WriteLine("Faixa etária: Idoso");
    }
}
