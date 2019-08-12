using ProjectBuilder.Application.Dtos.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBuilder.WebAPI.Models.Project
{
    public class ProjectListViewModel
    {
        public IEnumerable<ProjectDto> Projects { get; set; }

        public int Count => Projects.Count();
    }
}
