using System;
using System.Collections.Generic;
using System.Text;

namespace ArvatoInventory.Models
{
    public class Zebra
    {
        public int Id { get; set; }
        public string Producent { get; set; }
        public string Model { get; set; }
        public bool IsWorking { get; set; }
        public string Description { get; set; }
        public string FV { get; set; }
        public DateTime? Gurantee { get; set; }
    }
}
