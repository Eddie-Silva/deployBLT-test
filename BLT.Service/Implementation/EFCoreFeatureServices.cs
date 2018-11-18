using BLT.Data.Data;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.Implementation
{
    public class EFCoreFeatureServices : IFeatureServices
    {
        private readonly BLTDbContext _dbContext;

        public EFCoreFeatureServices(BLTDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Feature CreateFeature(Feature newFeature)
        {
            _dbContext.Features.Add(newFeature);
            _dbContext.SaveChanges();

            return newFeature;
        }

        public bool DeleteFeature(int id)
        {
            var feature = _dbContext.Features.Where(f => f.Id == id).FirstOrDefault();

            _dbContext.Features.Remove(feature);
            _dbContext.SaveChanges();

            if(!_dbContext.Features.Contains(feature))
            {
                return true;
            }

            return false;

        }

        public Feature GetFeatureById(int id) => _dbContext.Features.Where(f => f.Id == id).FirstOrDefault();

        public Feature GetFeatureByScenarioId(int id)
        {
            var scenario = _dbContext.Scenarios.Where(s => s.Id == id).FirstOrDefault();
            var featId = scenario.FeatureId;

            return GetFeatureById(featId);
        
        }

        public List<Feature> GetFeaturesByProjectId(int id) =>
            _dbContext.Features.Where(f => f.ProjectId == id).ToList();

        public Feature UpdateFeature(Feature updatedFeature)
        {
            var feature = GetFeatureById(updatedFeature.Id);
            _dbContext.Features.Remove(feature);
            _dbContext.Features.Add(updatedFeature);
            _dbContext.SaveChanges();

            return updatedFeature;

        }
    }
}
