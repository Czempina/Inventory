using System;
using System.Collections.Generic;
using System.Text;

namespace ArvatoInventory.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ESPName { get; set; }
        public string Brand { get; set; }
        public bool IsWorking { get; set; }
        public string Description { get; set; }
        public int PrinterId { get; set; }
        public int ZebraId { get; set; }
        public int ComputerId { get; set; }
    }
}
