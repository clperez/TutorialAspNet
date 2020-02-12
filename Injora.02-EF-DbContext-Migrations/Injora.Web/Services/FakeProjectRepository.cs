using Injora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora.Services
{
    public class FakeProjectRepository : IProjectRepository
    {
        public IQueryable<Project> Projects => new List<Project> {
            new Project { Name = "Football", CampaignMinimum = 25 },
            new Project { Name = "Surf board", CampaignMinimum = 179 },
            new Project { Name = "Running shoes", CampaignMinimum = 95 } }
        .AsQueryable();
    }
}
