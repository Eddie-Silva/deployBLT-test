using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Domain.Models
{
    public class Scenario
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public bool IsOutline { get; set; }
        public bool HasBackground { get; set; }
        public string Background { get; set; }
        public List<string> Examples { get; set; }
        public List<Step> StepList { get; set; }

        // Navigator
        public int FeatureId { get; set; }
    }
}
