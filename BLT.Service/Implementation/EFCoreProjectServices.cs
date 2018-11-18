using BLT.Data.Data;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.Implementation
{
    public class EFCoreProjectServices : IProjectServices
    {
        private readonly BLTDbContext _dbContext;

        public EFCoreProjectServices(BLTDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Project CreateProject(Project newProject)
        {
            _dbContext.Projects.Add(newProject);
            _dbContext.SaveChanges();

            return newProject;
        }

        public bool DeleteProject(int id)
        {
            var project = _dbContext.Projects.Where(p => p.Id == id).FirstOrDefault();
            _dbContext.Projects.Remove(project);
            _dbContext.SaveChanges();

            if(!_dbContext.Projects.Contains(project))
            {
                return true;
            }

            return false;
        }

        public List<Project> GetAllProjects() => _dbContext.Projects.ToList();

        public Project GetProjectById(int id) => _dbContext.Projects.Where(p => p.Id == id).FirstOrDefault();

        public Project UpdateProject(Project updatedProject)
        {
            var project = GetProjectById(updatedProject.Id);
            _dbContext.Projects.Remove(project);
            _dbContext.Projects.Add(updatedProject);
            _dbContext.SaveChanges();

            return updatedProject;
        }
    }
}
