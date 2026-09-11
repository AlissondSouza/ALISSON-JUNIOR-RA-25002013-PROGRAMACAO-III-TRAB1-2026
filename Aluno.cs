namespace Trabalho1ProgramacaoIII.Classes;

public class Aluno
{
    public string Nome { get; set; } = string.Empty;
    public string RA { get; set; } = string.Empty;
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double Frequencia { get; set; }

    public double CalcularMedia()
    {
        return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
    }

    public bool AprovadoPorFrequencia()
    {
        // O limite de faltas é 40%, então é necessário ter pelo menos 60% de frequência.
        return Frequencia >= 60;
    }

    public bool Aprovado()
    {
        return CalcularMedia() >= 7 && AprovadoPorFrequencia();
    }
}
