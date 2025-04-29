using Fitness_App.BL.Interfaces;
using Fitness_App.DAL.DbContext;
using Fitness_App.DAL.Models;
using Microsoft.AspNetCore.Hosting;

namespace Fitness_App.DAL.Repositories
{
    public class AdminRepository<T> : IAdminRepository<T> where T : class
    {
        private readonly FitnessAppDbContext context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminRepository(FitnessAppDbContext _context, IWebHostEnvironment webHostEnvironment)
        {
            context = _context;
            _webHostEnvironment = webHostEnvironment;
        }

        public void AddBlogs(Blogs blog)
        {
            throw new NotImplementedException();
        }
        ///////////////////////////////////////////////////////////
        public void AddDietPlan(DietPlans dietPlan)
        {
            if (dietPlan == null)
            {
                throw new ArgumentNullException(nameof(dietPlan));
            }

            context.DietPlans.Add(dietPlan);
            context.SaveChanges();
        }
        public void DeleteDietPlan(int id)
        {
            var dietPlan = context.DietPlans.Find(id);
            if (dietPlan != null)
            {
                // Delete the associated image file
                if (!string.IsNullOrEmpty(dietPlan.ImagePath))
                {
                    var filePath = Path.Combine(_webHostEnvironment.WebRootPath, dietPlan.ImagePath);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                context.DietPlans.Remove(dietPlan);
                context.SaveChanges();
            }
        }
        public IEnumerable<DietPlans> GetAllDietPlans()
        {
            return context.DietPlans.ToList();
        }
        public T GetDietPlanById(int id)
        {
            return context.DietPlans.Find(id) as T;
        }
        /////////////////////////////////////////////////////////
        public void AddExercise(Exercises exercises)
        {
            throw new NotImplementedException();
        }

        public T AdminsManagement()
        {
            throw new NotImplementedException();
        }

        public T ChangePassword(T user)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlogs(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCoach(Coach coach)
        {
            throw new NotImplementedException();
        }


        public void DeleteExercise(Exercises exercises)
        {
            throw new NotImplementedException();
        }


        public T GetAllFeedback()
        {
            throw new NotImplementedException();
        }

        public T GetCoachById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetCoachData()
        {
            throw new NotImplementedException();
        }

        public T GetExerciseData()
        {
            throw new NotImplementedException();
        }

        public T GetUsersData()
        {
            throw new NotImplementedException();
        }

        public T Login(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public T Logout(string FName, string LName, string Password)
        {
            throw new NotImplementedException();
        }

        public T Register(T user)
        {
            throw new NotImplementedException();
        }

        public T ShowSystemAnalytics()
        {
            throw new NotImplementedException();
        }

        public void UpdateBlogs(Blogs blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoach(Coach coach)
        {
            throw new NotImplementedException();
        }

        public T UpdateExercise(Exercises exercises)
        {
            throw new NotImplementedException();
        }

        public T UpdateProfile(T user)
        {
            throw new NotImplementedException();
        }

    }
}
