using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Data.MockData
{
    public static class MockProject
    {
        public static List<Project> list = new List<Project>()
        {
            new Project {Id = 1, Name = "ProjectA"},
            new Project {Id = 2, Name = "ProjectB"}
        };
    }
}
