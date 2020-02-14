using Injora.Models;
using Injora.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora.Services
{
    public class EFProjectsRepository : IProjectRepository
    {
        private readonly ApplicationDbContext context;
        public EFProjectsRepository(ApplicationDbContext context) { this.context = context; }
        public IQueryable<Project> Projects => context.Projects;
    }
}
