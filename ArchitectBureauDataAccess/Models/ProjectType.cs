using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArchitectBureauDataAccess.Models
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