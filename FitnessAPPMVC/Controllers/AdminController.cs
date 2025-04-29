using Fitness_App.BL.Servecies;
using Fitness_App.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAPPMVC.Controllers
{

    public class AdminController : Controller
    {
        //private readonly BlogServecies servecie;

        //public AdminController(BlogServecies servecie)
        //{
        //    this.servecie = servecie;
        //}
        //public IActionResult AddBlog()
        //{
        //    return View("AddBlog");
        //}
        //public IActionResult SaveAddBlog(BlogViewModel blogViewModel)
        //{

        //    servecie.AddBlog(blogViewModel);
        //    return View("AddBlog");
        //}
        /////////////////////////tarek/////////////////////////
        private readonly DietPlanService _dietPlanService;
        public AdminController(DietPlanService dietPlanService)
        {
            _dietPlanService = dietPlanService;
        }


       
        public IActionResult DietPlanManagement()
        {
            var dietPlans = _dietPlanService.GetAllDietPlans();
            return View(dietPlans);
            
        }

        // Step 2: Show the Add Diet Plan Form
        public IActionResult AddDietPlan()
        {
            
            return View();
        }

        // Step 3: Handle Form Submission
        [HttpPost]
        public async Task<IActionResult> AddDietPlan(DietPlanViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _dietPlanService.AddDietPlanAsync(model);
                return RedirectToAction("DietPlanManagement");
            }

            return View(model); // If invalid, stay on form
        }

        public IActionResult DeleteDietPlan(int id)
        {
            _dietPlanService.DeleteDietPlan(id);
            return RedirectToAction("DietPlanManagement");
        }
       


        /////////////////////////tarek/////////////////////////



    }
}
