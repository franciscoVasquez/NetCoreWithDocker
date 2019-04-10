using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreCodeFirstSample.Models;
using Microsoft.AspNetCore.Mvc;
using SoccerCourtReserve.Business;
using SoccerCourtReserve.ViewModel;

namespace SoccerCourtReserve.Controllers
{
    public class ReserveController : Controller
    {
        private ICourtContext _context;

        public ReserveController(ICourtContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Court> model = _context.GetCourtInfo();
            return View(model);
        }

        public PartialViewResult GetTableReserve()
        {
            ReserveViewModel model = new ReserveViewModel();
            model.Time = new List<string> { "7", "8", "9", "10", "11", "12", "13", "14" };
            return PartialView(model);
        }
    }
}