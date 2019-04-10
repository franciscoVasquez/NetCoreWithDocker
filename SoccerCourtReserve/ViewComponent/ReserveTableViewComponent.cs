using Microsoft.AspNetCore.Mvc;
using SoccerCourtReserve.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoccerCourtReserve.ViewComponents
{

    public class ReserveTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ReserveViewModel model = new ReserveViewModel();
            model.Time = new List<string> { "7", "8", "9", "10", "11", "12", "13", "14" };
            return View(model);
        }
    }
}
