namespace Trabalho1ProgramacaoIII.Classes;

public static class Exercicio01
{
    public static void Executar()
    {
        Console.WriteLine("=== EXERCÍCIO 1 - CALCULADORA ===");

        double primeiro = Program.LerDouble("Digite o primeiro número: ");
        double segundo = Program.LerDouble("Digite o segundo número: ");

        Console.WriteLine("\nOperações:");
        Console.WriteLine("+ - Soma");
        Console.WriteLine("- - Subtração");
        Console.WriteLine("* - Multiplicação");
        Console.WriteLine("/ - Divisão");
        Console.WriteLine("% - Resto da divisão");

        Console.Write("Escolha a operação: ");
        string operacao = (Console.ReadLine() ?? string.Empty).Trim();

        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultado: {primeiro + segundo}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {primeiro - segundo}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {primeiro * segundo}");
                break;
            case "/":
                if (segundo == 0)
                    Console.WriteLine("Não é possível dividir por zero.");
                else
                    Console.WriteLine($"Resultado: {primeiro / segundo}");
                break;
            case "%":
                if (segundo == 0)
                    Console.WriteLine("Não é possível calcular o resto com divisor zero.");
                else
                    Console.WriteLine($"Resultado: {primeiro % segundo}");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }
}
