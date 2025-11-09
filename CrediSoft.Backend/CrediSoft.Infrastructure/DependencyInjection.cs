using CrediSoft.Domain.Interfaces;
using CrediSoft.Infrastructure.Persistence;
using CrediSoft.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrediSoft.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CrediSoftDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("CrediSoftConnection")));

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ILoanRepository, LoanRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
