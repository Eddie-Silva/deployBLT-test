using BLT.Data.MockData;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.MockImplementation
{
    public class MockScenarioServices : IScenarioServices
    {
        private List<Scenario> _context;

        public MockScenarioServices()
        {
            _context = MockScenario.list;
        }

        public Scenario CreateScenario(Scenario newScenario)
        {
            _context.Add(newScenario);
            return newScenario;
        }

        public bool DeleteScenario(int id)
        {
            var toDelete = GetScenarioById(id);
            _context.Remove(toDelete);

            toDelete = GetScenarioById(id);
            if(toDelete == null)
            {
                return true;
            }
            return false;

        }

        public Scenario GetScenarioById(int id) => _context.Where(s => s.Id == id).FirstOrDefault();

        public List<Scenario> GetScenariosByFeature(Feature feature) =>
            _context.Where(s => s.FeatureId == feature.Id).ToList();

        public Scenario UpdateScenario(Scenario updatedScenario)
        {
            Scenario oldScenario = GetScenarioById(updatedScenario.Id);

            _context.Remove(oldScenario);
            _context.Add(updatedScenario);

            return updatedScenario;
        }
    }
}
