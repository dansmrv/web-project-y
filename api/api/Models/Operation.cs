using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Operation
    {
        public Guid Id { get; set; } //GUID - ?
        public Guid ContainerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string OperationType { get; set; } = string.Empty;
        public string OparatorFullName { get; set; } = string.Empty;
        public string InspectionPlace { get; set; } = string.Empty;
        public Container Container { get; set; } 


    }
}