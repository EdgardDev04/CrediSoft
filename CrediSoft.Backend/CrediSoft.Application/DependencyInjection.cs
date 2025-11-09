using CrediSoft.Application.Interfaces;
using CrediSoft.Application.Profiles;
using CrediSoft.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CrediSoft.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<ClientProfile>();
                cfg.AddProfile<LoanProfile>();
                cfg.AddProfile<UserProfile>();
            });

            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<ILoanService, LoanService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
