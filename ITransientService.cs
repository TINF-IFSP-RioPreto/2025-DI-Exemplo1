using Microsoft.Extensions.DependencyInjection;

namespace IDConsole.Exemplo;

public interface ITransientService: IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime =>
        ServiceLifetime.Transient;
}
