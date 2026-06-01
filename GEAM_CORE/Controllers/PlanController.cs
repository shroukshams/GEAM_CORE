using Microsoft.AspNetCore.Mvc;
using GEAM_CORE.context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using GEAM_CORE.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
namespace GEAM_CORE.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContexts context;

        public PlanController()
        {
            context = new GymDbContexts();
        }

        //Get:BaseUrl/Plan/Index

        public async  Task <IActionResult> Index()
        {
var plans = await context.Plans.ToListAsync<Plan>();


            return View(plans);

        }
    }
}
