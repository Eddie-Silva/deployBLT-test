using BLT.Data.MockData;
using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLT.Service.MockImplementation
{
    public class MockStepServiceCRUD : IStepServicesCRUD
    {
        private List<Scenario> _context;

        public MockStepServiceCRUD()
        {
            _context = MockScenario.list;
        }

        public Step CreateStep(Step newStep, Scenario scenario)
        {
            _context.Where(s => s.Id == scenario.Id).FirstOrDefault()
                .StepList.Add(newStep);
            return newStep;
        }

        public bool DeleteStep(int id, Scenario scenario)
        {
            var step = GetStepById(id, scenario);

            _context.Where(s => s.Id == scenario.Id).FirstOrDefault()
                .StepList.Remove(step);
            if(!_context.Where(s => s.Id == scenario.Id).FirstOrDefault()
                    .StepList.Contains(step))
            {
                return true;
            }

            return false;
        }

        public Step GetStepById(int id, Scenario scenario) =>
            _context.Where(s => s.Id == scenario.Id)
                .FirstOrDefault().StepList.Where(l => l.Id == id).FirstOrDefault();

        public Step UpdateStep(Step updatedStep, Scenario scenario)
        {
            var step = GetStepById(updatedStep.Id, scenario);

            _context.Where(s => s.Id == scenario.Id).FirstOrDefault()
                .StepList.Remove(step);

            _context.Where(s => s.Id == scenario.Id).FirstOrDefault()
                .StepList.Add(updatedStep);

            return updatedStep;
        }
    }
}
