using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_GymManagement.Contexts;

namespace MVC_GymManagement.Controllers.Plan
{
    public class PlanController : Controller
    {
        private readonly GymDbContext gymDbContext = new GymDbContext();

        public async Task<IActionResult> Index() 
        {
            var plans = await gymDbContext.Plans.ToListAsync();
            return View(plans);
        }
    }
}
