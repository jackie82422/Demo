using Microsoft.Extensions.DependencyInjection;

namespace Demo
{
    public static class Injection
    {
        public static IServiceCollection InjectAll(this IServiceCollection serviceCollection)
        {
            InjectUtils(serviceCollection);
            return serviceCollection;
        }

        public static IServiceCollection InjectUtils(this IServiceCollection serviceCollection)
        {
            // serviceCollection.AddSingleton<ILogUtils, LogUtils>();
            return serviceCollection;
        }
    }
}