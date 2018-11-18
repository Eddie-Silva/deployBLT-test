using BLT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLT.Data.MockData
{
    public static class MockFeature
    {
        public static List<Feature> list = new List<Feature>()
        {
            new Feature {Id = 1, Name = "FeatureA", ProjectId = 1},
            new Feature {Id = 2, Name = "FeatureB", ProjectId = 1},
            new Feature {Id = 3, Name = "FeatureC", ProjectId = 2},
        };
    }
}
