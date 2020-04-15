using System;
using JuicerLib.Models.Enums;

namespace JuicerLib.Models
{
    public class CurrencyModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public Groups Group { get; set; }
        public long? StackSize { get; set; }
        public Uri Icon { get; set; }
        public double Mean { get; set; }
        public double Median { get; set; }
        public double Mode { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Exalted { get; set; }
        public long Total { get; set; }
        public long Daily { get; set; }
        public long Current { get; set; }
        public long Accepted { get; set; }
        public double Change { get; set; }
    }
}