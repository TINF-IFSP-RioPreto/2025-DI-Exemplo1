namespace IDConsole.Exemplo;

internal sealed class ServicoScoped : IScopedService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}
