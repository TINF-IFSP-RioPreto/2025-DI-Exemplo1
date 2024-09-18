namespace IDConsole.Exemplo;

internal sealed class ServicoMostrarCicloDeVida(
    ITransientService servicoTransiente,
    IScopedService servicoScoped,
    ISingletonService servicoSingleton)
{
    public void MostrarDetalhes(string detalhes)
    {
        Console.WriteLine(detalhes);

        MostraServico(servicoTransiente, "Sempre diferente");
        MostraServico(servicoScoped, "Permanece durante o ciclo de vida");
        MostraServico(servicoSingleton, "Sempre igual");
    }

    private static void MostraServico<T>(T servico, string mensagem)
        where T : IReportServiceLifetime => Console.WriteLine(
        $"{typeof(T).Name}: {servico.Id} ({mensagem})");

}
