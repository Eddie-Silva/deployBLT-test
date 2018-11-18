using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Data.MockData
{
    public static class MockScenario
    {
        public static List<Scenario> list = new List<Scenario>()
        {
            new Scenario {Id = 1, Background = "This is a test Background", HasBackground = true, IsOutline = false, Header = "Example Header describing ScenarioA", FeatureId = 1, StepList = new List<Step>() { new Step { Content = "Test content for step" }  } },
            new Scenario {Id = 2, Background = "This is a test Background", HasBackground = true, IsOutline = false, Header = "Example Header describing the ScenarioB", FeatureId = 1, StepList = new List<Step>() }
        };

        public static List<Step> stepList = new List<Step>()
        {
            new Step {Content = "Click the button."},
            new Step {Content = "Click the link."},
            new Step {Content = "Click the banner."}
        };
    }
}
