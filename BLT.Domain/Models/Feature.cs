using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Domain.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigator
        public int ProjectId { get; set; }
    }
}
