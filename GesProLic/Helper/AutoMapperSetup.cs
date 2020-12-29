using AutoMapper;
using GesProLic.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace GesProLic.API.Helper
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            var config = AutoMapperConfig.RegisterMapper();

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
