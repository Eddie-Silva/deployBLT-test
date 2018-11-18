using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Data.MockData
{
    public static class MockStepList
    {
        public static List<Step> list = new List<Step>()
        {
            new Step {Content = "Click the button."},
            new Step {Content = "Click the link."},
            new Step {Content = "Click the banner."}
        };
    }
}
