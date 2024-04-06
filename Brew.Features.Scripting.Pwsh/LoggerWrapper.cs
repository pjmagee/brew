using Microsoft.Extensions.Logging;

namespace Brew.Features.Scripting.Pwsh;

public class LoggerWrapper(ILogger logger)
{
    public void LogInformation(string message)
    {
        logger.LogInformation("{Output}", message);
    }
}