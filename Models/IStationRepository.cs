using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvatoInventory.Models
{
    public interface IStationRepository
    {
        IQueryable<Station> Stations { get; }
    }
}
