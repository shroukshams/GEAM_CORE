using GEAM_CORE.context;
using GEAM_CORE.Models;
using GymMangment.BLL.Repositories.Classes;
using GymMangment.BLL.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
namespace GEAM_CORE.Controllers
{
    public class PlanController : Controller
    {
        // private readonly GymDbContexts context;
        private readonly IPlanRepository planRepository;
        public PlanController(IPlanRepository planRepository)
        {
            this.planRepository = planRepository;
        }



        //Get:BaseUrl/Plan/Index

        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var plans = await planRepository.GetAllAsync(ct: ct);//pass by name
            return View(plans);
        }

        public async Task<IActionResult> Details(int id, CancellationToken ct)
            {
                 var plan = await planRepository.GetByIdAsync(id, ct);
         
                if (plan == null)
                     {
                  return RedirectToAction(nameof(Index));
    }
    else
          {  return View(plan);
}


        
   
        
    }
  


    }
    }

