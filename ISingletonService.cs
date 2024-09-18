using Microsoft.Extensions.DependencyInjection;

namespace IDConsole.Exemplo;

public interface ISingletonService: IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime =>
        ServiceLifetime.Singleton;
}
