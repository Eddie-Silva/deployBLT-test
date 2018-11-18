using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLT.UI.ViewModels
{
    public class ScenariosViewModel
    {
        public Feature Feature { get; set; }
        public List<Scenario> Scenarios { get; set; }
    }
}
