using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Implementation
{
    public class SelectorStepService : IStepServiceSelectable, IStepServiceQueryable
    {
        public Step CheckForXAndYInElement(string element, string x, string y)
        {
            Step step = new Step();
            step.Content = $"Check that \"{element}\" contains \"{x}\" and \"{y}\".";

            return step;
        }

        public Step CheckForXInElement(string element, string x)
        {
            Step step = new Step();
            step.Content = $"Check that \"{element}\" contains \"{x}\".";

            return step;
        }

        public Step UserChoosesRadioById(string radioId)
        {
            Step step = new Step();
            step.Content = $"User chooses \"{radioId}\" by Id.";

            return step;
        }

        public Step UserChoosesRadioByValue(string buttonValue)
        {
            Step step = new Step();
            step.Content = $"User chooses \"{buttonValue}\" by value.";
            return step;
        }

        public Step UserIsOnXPage(string x)
        {
            Step step = new Step();
            step.Content = $"User is on \"{x}\" page.";
            return step;
        }

        public Step UserIsSentToX(string x)
        {
            Step step = new Step();
            step.Content = $"User is sent to \"{x}\" page.";
            return step;
        }
    }
}
