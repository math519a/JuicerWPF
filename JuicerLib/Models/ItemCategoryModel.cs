using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace JuicerLib.Models
{
    

    public class ItemCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public List<Group> Groups { get; set; }

        public class Group
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Display { get; set; }
        }
    }
}