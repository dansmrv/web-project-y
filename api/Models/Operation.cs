using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Operation
    {
        public int Id { get; set; } //GUID - ?
        public int IdContainer { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string Type { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public int MyProperty { get; set; }
        public string InspectionPlace { get; set; } = string.Empty;

    }
}