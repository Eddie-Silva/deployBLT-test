using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IStepServicesCRUD
    {
        // Read
        Step GetStepById(int id, Scenario scenario);

        // Create
        Step CreateStep(Step newStep, Scenario scenario);

        //Update
        Step UpdateStep(Step updatedStep, Scenario scenario);

        // Delete
        bool DeleteStep(int id, Scenario scenario);
    }
}
