using Injora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora.Services
{
    public interface IProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
