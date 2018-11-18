using BLT.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Data.Data
{
    public class BLTDbContext : DbContext
    {
        public List<Project> Projects { get; set; }
        public List<Feature> Features { get; set; }
        public List<Scenario> Scenarios { get; set; }

        public BLTDbContext(DbContextOptions<BLTDbContext> options)
            : base(options)
        {

        }
    }
}
