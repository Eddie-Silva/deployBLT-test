using BLT.Data.Data;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.Implementation
{
    public class EFCoreScenarioServices : IScenarioServices
    {
        private readonly BLTDbContext _dbContext;

        public EFCoreScenarioServices(BLTDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Scenario CreateScenario(Scenario newScenario)
        {
            _dbContext.Scenarios.Add(newScenario);
            _dbContext.SaveChanges();

            return newScenario;
        }

        public bool DeleteScenario(int id)
        {
            var scenario = _dbContext.Scenarios.Where(s => s.Id == id).FirstOrDefault();

            _dbContext.Scenarios.Remove(scenario);
            _dbContext.SaveChanges();

            if(!_dbContext.Scenarios.Contains(scenario))
            {
                return true;
            }

            return false;
        }

        public Scenario GetScenarioById(int id) =>
            _dbContext.Scenarios.Where(s => s.Id == id).FirstOrDefault();

        public List<Scenario> GetScenariosByFeature(Feature feature) =>
            _dbContext.Scenarios.Where(s => s.FeatureId == feature.Id).ToList();

        public Scenario UpdateScenario(Scenario updatedScenario)
        {
            var scenario = GetScenarioById(updatedScenario.Id);
            _dbContext.Scenarios.Remove(scenario);
            _dbContext.Scenarios.Add(updatedScenario);

            return updatedScenario;
        }
    }
}
