using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Injora.Services;
using Injora.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Qwantalabs.Shared;
using Qwantalabs.Shared.AspNetCore.IoC;

namespace Injora.Components
{
    public class ProjectDbRepository : IComponent
    {
        public void Setup(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration["Data:InjoraProjects:ConnectionString"]));
            services.AddTransient<IProjectRepository, EFProjectsRepository>();
        }
    }
}
