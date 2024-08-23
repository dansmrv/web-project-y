using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Container
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Lenght { get; set; }
        public int  Width { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public byte IsEmpty { get; set; }
        public DateTime ArivingDate { get; set; } = DateTime.Now;
    }
}