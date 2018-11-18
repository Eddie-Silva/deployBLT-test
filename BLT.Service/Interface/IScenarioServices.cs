using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IScenarioServices
    {
        // Read 
        List<Scenario> GetScenariosByFeature(Feature feature);
        Scenario GetScenarioById(int id);

        // Create 
        Scenario CreateScenario(Scenario newScenario);

        // Update
        Scenario UpdateScenario(Scenario updatedScenario);

        // Delete
        bool DeleteScenario(int id);
    }
}
