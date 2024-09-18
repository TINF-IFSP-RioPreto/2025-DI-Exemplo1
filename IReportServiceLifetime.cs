using Microsoft.Extensions.DependencyInjection;

namespace IDConsole.Exemplo;

public interface IReportServiceLifetime
{
    public Guid Id { get; }
    public ServiceLifetime Lifetime { get; }
}
