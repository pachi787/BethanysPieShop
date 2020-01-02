using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PieFunction;

[assembly: FunctionsStartup(typeof(MyNamespace.Startup))]

namespace MyNamespace
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<FunctionDBContext>(options =>
                                        options.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=BethanysPieShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"),
                                        optionsLifetime:ServiceLifetime.Scoped);
            builder.Services.AddTransient<IPieRepository, PieFunctionRepo>();
        }
    }
}