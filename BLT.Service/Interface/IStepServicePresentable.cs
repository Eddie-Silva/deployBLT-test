using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IStepServicePresentable
    {
        // Logging In
        Step UserLogsIn(string name, string pword);

        // Forms
        Step UserTypesXInField(string content, string field);
    }
}
