using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLT.UI.ViewModels
{
    public class CreateFeatureViewModel
    {
        public Project Project { get; set; }
        public Feature Feature { get; set; }
        public Scenario Scenario { get; set; }
        public Step Step { get; set; }
    }
}
