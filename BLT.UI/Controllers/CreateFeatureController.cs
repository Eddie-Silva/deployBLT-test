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
    public class CreateFeatureController : Controller
    {
        private readonly IStepServiceNavigable _navigableService;
        private readonly IStepServicePresentable _presentableService;
        private readonly IStepServiceQueryable _queryableService;
        private readonly IStepServiceSelectable _selectableService;
        private readonly IStepServicesCRUD _crudService;

        public CreateFeatureController(IStepServiceNavigable navigableService,
            IStepServicePresentable presentableService,
            IStepServiceQueryable queryableService,
            IStepServiceSelectable selectableService,
            IStepServicesCRUD crudService)
        {
            _navigableService = navigableService;
            _presentableService = presentableService;
            _queryableService = queryableService;
            _selectableService = selectableService;
            _crudService = crudService;
        }

        public IActionResult Index(CreateFeatureViewModel viewModel) => View(viewModel);

        [HttpGet]

        //-------test code--------
        public IActionResult Background() => View();
        public IActionResult Scenario() => View();
        public IActionResult Outline() => View();
        public IActionResult FinishedFIle() => View();
       //----------end test code--------
    

        public IActionResult NewProject()
        {
            var project = new Project();
            return View(project);
        }

        [HttpPost]
        public IActionResult NewProject(Project p)
        {
            return RedirectToAction("NewFeature", p);
        }

        public IActionResult Edit(Feature feature)
        {
            var model = new EditViewModel
            {
                Feature = feature
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult NewFeature(Project project)
        {
            var model = new CreateFeatureViewModel()
            {
                Project = project
            };

            return View(model);
        }

        // Feature Component Actions
        public IActionResult GetHeader(string content, CreateFeatureViewModel viewModel)
        {
            viewModel.Scenario.Header = "Scenario: " + content;
            return RedirectToAction("Index", viewModel);
        }

        public IActionResult GetBackground(string content, CreateFeatureViewModel viewModel)
        {
            viewModel.Scenario.HasBackground = true;
            viewModel.Scenario.Background = "Background:" + Environment.NewLine + content;
            return RedirectToAction("Index", viewModel);
        }

        // Queryable Actions
        public IActionResult UserIsOnXPage(string x, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _queryableService.UserIsOnXPage(x);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        public IActionResult UserIsSentToX(string x, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _queryableService.UserIsSentToX(x);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        public IActionResult CheckForXInElement(string element, string x, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _queryableService.CheckForXInElement(element, x);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        public IActionResult CheckForXAndYInElement(string element, string x, string y, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _queryableService.CheckForXAndYInElement(element, x, y);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        // Presentable Actions
        public IActionResult UserLogsIn(string name, string pword, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _presentableService.UserLogsIn(name, pword);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        public IActionResult UserTypesXInField(string content, string field, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _presentableService.UserTypesXInField(content, field);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        // Navigable Actions
        public IActionResult UserClicksLinkOrButton(string link, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _navigableService.UserClicksLinkOrButton(link);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        public IActionResult Pause(int seconds, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _navigableService.Pause(seconds);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }

        // Selectable Actions
        public IActionResult UserChoosesRadioById(string radioId, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _selectableService.UserChoosesRadioById(radioId);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }


        public IActionResult UserChoosesRadioByValue(string buttonValue, CreateFeatureViewModel viewModel)
        {
            var step = new Step();
            step = _selectableService.UserChoosesRadioByValue(buttonValue);
            viewModel.Scenario.StepList.Add(step);
            return RedirectToAction("Index", viewModel);
        }
        
    }
}