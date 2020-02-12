using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qwantalabs.Shared
{
    public static class IoC
    {
        public interface IComponent
        {
            void Setup(IServiceCollection services);
        }

        public static void SetupIoC (this IServiceCollection services, Type type)
        {
            var componentTypes = Array.FindAll(type.Assembly.GetTypes(), t => typeof(IComponent).IsAssignableFrom(t));
            Array.ForEach(componentTypes, t => ((IComponent)(Activator.CreateInstance(t))).Setup(services));
        }
    }
}
