using BLT.Domain.Models;
using BLT.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Implementation
{
    public class ComponentStepService : IStepServicePresentable, IStepServiceNavigable
    {
        public Step Pause(int seconds)
        {
            Step step = new Step();
            step.Content = $"Pause for {seconds} seconds.";

            return step;
        }

        public Step UserClicksLinkOrButton(string link)
        {
            Step step = new Step();
            step.Content = $"User clicks \"{link}\".";
            return step;
        }

        public Step UserLogsIn(string name, string pword)
        {
            Step step = new Step();
            step.Content = $"User logs in with \"{name}\" and \"{pword}\".";
            return step;
        }

        public Step UserTypesXInField(string content, string field)
        {
            Step step = new Step();
            step.Content = $"User writes \"{content}\" in \"{field}\".";
            return step;
        }
    }
}
