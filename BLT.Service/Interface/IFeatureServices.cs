using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IFeatureServices
    {
        // Read 
        Feature GetFeatureById(int id);
        Feature GetFeatureByScenarioId(int id);
        List<Feature> GetFeaturesByProjectId(int id);

        // Create
        Feature CreateFeature(Feature newFeature);

        // Update
        Feature UpdateFeature(Feature updatedFeature);

        // Delete
        bool DeleteFeature(int id);
    }
}
