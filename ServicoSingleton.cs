namespace IDConsole.Exemplo;

internal sealed class ServicoSingleton : ISingletonService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}
