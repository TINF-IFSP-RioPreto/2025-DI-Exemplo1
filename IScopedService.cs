using Microsoft.Extensions.DependencyInjection;

namespace IDConsole.Exemplo;

public interface IScopedService: IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime =>
        ServiceLifetime.Scoped;
}
