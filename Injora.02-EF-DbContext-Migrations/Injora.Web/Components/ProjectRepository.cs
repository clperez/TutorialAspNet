using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Injora.Services;
using Microsoft.Extensions.DependencyInjection;
using Qwantalabs.Shared;

namespace Injora.Components
{
    public class ProjectRepository : IoC.IComponent
    {
        public void Setup(IServiceCollection services)
        {
            services.AddSingleton<IProjectRepository, FakeProjectRepository>();
        }
    }
}
