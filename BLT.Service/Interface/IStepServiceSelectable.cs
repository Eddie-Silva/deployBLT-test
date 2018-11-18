using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IStepServiceSelectable
    {
        // Radios
        Step UserChoosesRadioById(string radioId);
        Step UserChoosesRadioByValue(string buttonValue);
    }
}
