namespace IDConsole.Exemplo;

internal sealed class ServicoTransiente : ITransientService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}
