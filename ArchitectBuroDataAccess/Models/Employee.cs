using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectBuroDataAccess.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string HomeAddress { get; set; }
        public string Phone { get; set; }
        public DateTime ApplyDate { get; set; }

    }
}
