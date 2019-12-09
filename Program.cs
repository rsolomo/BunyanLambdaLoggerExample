using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BunyanLambdaLoggerExample
{
  public static class Program
  {
    public static void Main()
    {
      var provider = new ServiceCollection().BuildServiceProvider();
      var factory = provider.GetRequiredService<ILoggerFactory>();
      var logger = factory.AddBunyanLambdaLogger().CreateLogger("test");
      logger.LogInformation("Should log information with {0}", "argument");
    }
  }
}
