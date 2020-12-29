using Microsoft.Extensions.DependencyInjection;

namespace GesProLic.API
{
    public class DependencyInjection
    {
        public static void RegisterDependencyInjection(IServiceCollection services)
        {
            ConfigureServices(services);
            ConfigureQuery(services);
            ConfigureRepository(services);
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<IUserServices, UserServices>();
        }

        public static void ConfigureQuery(IServiceCollection services)
        {
            //services.AddScoped<IUserQuery, UserQuery>();
        }

        public static void ConfigureRepository(IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
