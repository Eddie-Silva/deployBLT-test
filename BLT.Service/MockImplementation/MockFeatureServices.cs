using BLT.Data.MockData;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.MockImplementation
{
    public class MockFeatureServices : IFeatureServices
    {
        private List<Feature> _context;

        public MockFeatureServices()
        {
            _context = MockFeature.list;
        }

        public Feature CreateFeature(Feature newFeature)
        {
            _context.Add(newFeature);
            return newFeature;

        }

        public bool DeleteFeature(int id)
        {
            var toBeDeleted = GetFeatureById(id);
            _context.Remove(toBeDeleted);

            toBeDeleted = GetFeatureById(id);
            if(toBeDeleted == null)
            {
                return true;
            }

            return false;
        }

        public Feature GetFeatureById(int id) => _context.Where(f => f.Id == id).FirstOrDefault();

        public Feature GetFeatureByScenarioId(int id)
        {
            var scenario = MockScenario.list.Where(s => s.Id == id).FirstOrDefault();
            var featId = scenario.FeatureId;

            return GetFeatureById(featId);
        }

        public List<Feature> GetFeaturesByProjectId(int id) => _context.Where(f => f.ProjectId == id).ToList();

        public Feature UpdateFeature(Feature updatedFeature)
        {
            Feature oldFeature = GetFeatureById(updatedFeature.Id);

            _context.Remove(oldFeature);
            _context.Add(updatedFeature);

            return updatedFeature;
        }
    }
}
