using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLT.Domain.Models;
using BLT.Service.Interface;
using BLT.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BLT.UI.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IProjectServices _projectServices;
        private readonly IScenarioServices _scenarioServices;
        private readonly IFeatureServices _featureServices;

        public FeaturesController(IProjectServices projectServices,
            IScenarioServices scenarioServices,
            IFeatureServices featureServices)
        {
            _featureServices = featureServices;
            _projectServices = projectServices;
            _scenarioServices = scenarioServices;

        }

        public IActionResult Index()
        {
            var model = new ProjectsViewModel
            {
                Projects = _projectServices.GetAllProjects()
            };

            return View(model);
        }

        public IActionResult Features(Project project)
        {
            var model = new FeaturesViewModel
            {
                Features = _featureServices.GetFeaturesByProjectId(project.Id)
            };

            return View(model);
        }

        public IActionResult Scenarios(Feature feature)
        {
            var model = new ScenariosViewModel
            {
                Scenarios = _scenarioServices.GetScenariosByFeature(feature).ToList()
            };
            return View(model);
        }

        public IActionResult AllScenarios(Feature feature)
        {
            var model = new ScenariosViewModel
            {
                Scenarios = _scenarioServices.GetScenariosByFeature(feature).ToList(),
                Feature = feature
            };
            return View(model);
        }

        public IActionResult Steps(Scenario scenario)
        {
            var model = new StepsViewModel()
            {
                Feature = _featureServices.GetFeatureByScenarioId(scenario.Id),
                Scenario = scenario
            };

            Step step = new Step();
            step.Content = "Test Content for Step";
            model.Scenario.StepList.Add(step);
            
            return View(model);
        }
    }
}