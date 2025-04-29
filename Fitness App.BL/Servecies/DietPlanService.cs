using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Interfaces;
using Fitness_App.BL.ViewModels;
using Fitness_App.DAL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;



namespace Fitness_App.BL.Servecies
{
    public class DietPlanService
    {
        private readonly IAdminRepository<DietPlans> _adminRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DietPlanService(IAdminRepository<DietPlans> adminRepository, IWebHostEnvironment webHostEnvironment)
        {
            _adminRepository = adminRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task AddDietPlanAsync(DietPlanViewModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            // Handle Image Upload
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images/dietplans");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await model.Image.CopyToAsync(fileStream);
            }

            // Map ViewModel to Model
            var dietPlan = new DietPlans
            {
                PlanTitle = model.PlanTitle,
                ImagePath = "images/dietplans/" + uniqueFileName,
                //AdminId = model.AdminId
            };

            _adminRepository.AddDietPlan(dietPlan);
        }

        public IEnumerable<DietPlans> GetAllDietPlans()
        {
            try
            {
                return _adminRepository.GetAllDietPlans() ?? Enumerable.Empty<DietPlans>();
            }
            catch (Exception ex)
            {
                // Log error here
                return Enumerable.Empty<DietPlans>();
            }
        }

        public void DeleteDietPlan(int id)
        {
            _adminRepository.DeleteDietPlan(id);
        }

        public DietPlans GetDietPlanById(int id)
        {
            return _adminRepository.GetDietPlanById(id);
        }
    }
}
