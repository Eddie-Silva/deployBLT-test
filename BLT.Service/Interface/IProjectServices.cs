using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IProjectServices
    {
        // Read
        List<Project> GetAllProjects();
        Project GetProjectById(int id);

        // Create
        Project CreateProject(Project newProject);

        // Update
        Project UpdateProject(Project updatedProject);

        // Delete
        bool DeleteProject(int id);

    }
}
