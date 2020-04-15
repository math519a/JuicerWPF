using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using JuicerLib.Models.Enums;

namespace JuicerLib.Models
{
    //Updated
    public class BaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public Groups Group { get; set; }
        public List<Influences> Influences { get; set; }  = new List<Influences>();
        public bool BaseIsShaper { get; set; }
        public bool BaseIsElder { get; set; }
        public long BaseItemLevel { get; set; }
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