using Entity.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvatoInventory.Models
{
    public class EFStationRepository : IStationRepository
    {
        private ApplicationDBContext context;
        public EFStationRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Station> Stations => context.stations;
    }
}
