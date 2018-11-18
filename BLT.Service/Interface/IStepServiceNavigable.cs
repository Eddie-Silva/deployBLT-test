using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IStepServiceNavigable
    {
        // Clicking
        Step UserClicksLinkOrButton(string link);

        // Miscellaneous
        Step Pause(int seconds);
    }
}
