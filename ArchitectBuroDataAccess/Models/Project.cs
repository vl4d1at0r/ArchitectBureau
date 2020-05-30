using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectBuroDataAccess.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int ProjectStatusId { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public int ProjectTypeId { get; set; }
        public ProjectType ProjectType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
