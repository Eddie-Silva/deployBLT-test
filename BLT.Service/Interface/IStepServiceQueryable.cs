using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Service.Interface
{
    public interface IStepServiceQueryable
    {
        // Page Queries
        Step UserIsOnXPage(string x);
        Step UserIsSentToX(string x);

        // Element Queries
        Step CheckForXInElement(string element, string x);
        Step CheckForXAndYInElement(string element, string x, string y);
    }
}
