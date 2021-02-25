using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArvatoInventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArvatoInventory.Controllers
{
    public class StationController : Controller
    {
            private IStationRepository repository;
            public StationController(IStationRepository repo)
            {
                repository = repo;
            }
        public ViewResult List() => View(repository.Stations);
    }
}
