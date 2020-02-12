﻿using Injora.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectRepository repository;
        public int PageSize = 4;


        public ProjectsController(IProjectRepository projectRepository)
        {
            repository = projectRepository;
        }

        [HttpGet]
        public ViewResult List(int productPage=1) => 
            View(repository.Projects.OrderBy(p=>p.ProjectID).Skip((productPage - 1) * PageSize).Take(PageSize));
    }
}