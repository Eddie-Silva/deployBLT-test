using BLT.Data.MockData;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.MockImplementation
{
    public class MockProjectServices : IProjectServices
    {
        public List<Project> _context;

        public MockProjectServices()
        {
            _context = MockProject.list;
        }

        public Project CreateProject(Project newProject)
        {
            _context.Add(newProject);
            return newProject;
        }

        public bool DeleteProject(int id)
        {
            var toDelete = GetProjectById(id);
            _context.Remove(toDelete);

            toDelete = GetProjectById(id);
            if(toDelete == null)
            {
                return true;
            }

            return false;
        }

        public List<Project> GetAllProjects() => _context;

        public Project GetProjectById(int id) => _context.Where(p => p.Id == id).FirstOrDefault();

        public Project UpdateProject(Project updatedProject)
        {
            var oldProject = GetProjectById(updatedProject.Id);

            _context.Remove(oldProject);
            _context.Add(updatedProject);

            return updatedProject;
        }
    }
}
