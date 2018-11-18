using BLT.Data.Data;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.Implementation
{
    public class EFCoreStepServices : IStepServicesCRUD
    {
        private readonly BLTDbContext _dbContext;

        public EFCoreStepServices(BLTDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Step CreateStep(Step newStep, Scenario scenario)
        {
            var scen = _dbContext.Scenarios.Where(s => s.Id == scenario.Id).FirstOrDefault();
            scen.StepList.Add(newStep);
            _dbContext.Scenarios.Remove(scenario);
            _dbContext.Scenarios.Add(scen);
            _dbContext.SaveChanges();

            return newStep;
        }

        public bool DeleteStep(int id, Scenario scenario)
        {
            var step = GetStepById(id, scenario);

            _dbContext.Scenarios.Where(s => s.Id == scenario.Id)
                .FirstOrDefault().StepList.Remove(step);

            _dbContext.SaveChanges();

            if(!_dbContext.Scenarios.Where(s => s.Id == scenario.Id)
                .FirstOrDefault().StepList.Contains(step))
            {
                return true;
            }

            return false;

        }

        public Step GetStepById(int id, Scenario scenario) => 
            _dbContext.Scenarios.Where(s => s.Id == scenario.Id)
                .FirstOrDefault().StepList.Where(l => l.Id == id).FirstOrDefault();

        public Step UpdateStep(Step updatedStep, Scenario scenario)
        {
            var step = GetStepById(updatedStep.Id, scenario);

            _dbContext.Scenarios.Where(s => s.Id == scenario.Id)
                .FirstOrDefault().StepList.Remove(step);

            _dbContext.Scenarios.Where(s => s.Id == scenario.Id)
                 .FirstOrDefault().StepList.Add(updatedStep);

            return updatedStep;
        }
    }
}
