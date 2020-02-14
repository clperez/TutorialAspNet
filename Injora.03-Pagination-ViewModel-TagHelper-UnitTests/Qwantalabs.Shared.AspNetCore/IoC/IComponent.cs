using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qwantalabs.Shared.AspNetCore.IoC
{
    public interface IComponent
    {
        void Setup(IServiceCollection services, IConfiguration configuration);
    }
}
