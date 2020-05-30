using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectBuroDataAccess.Models
{
    public class ProjectType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Term { get; set; }
        public List<Project> Projects { get; set; }
    }
}
