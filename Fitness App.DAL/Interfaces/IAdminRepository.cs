using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Models;
using Fitness_App.DAL.Models;

namespace Fitness_App.BL.Interfaces
{
    public interface IAdminRepository<T> : IUserRepository<T> where T : class
    {

       // mohammed
        T GetUsersData();

        // Exercise management
        T GetExerciseData();
        void AddExercise(Exercises exercises);
        void DeleteExercise(Exercises exercises);
        T UpdateExercise(Exercises exercises);

        //mohammed

        //sara
        // Coach Management

        //ADD coach
        T GetCoachData();
        T GetCoachById(int id);
        void UpdateCoach(Coach coach);
        void DeleteCoach(Coach coach);
        //sara

        //Zeiado
        // Blogs Management
        void AddBlogs(Blogs blog);
        
        void UpdateBlogs(Blogs blog);
        void DeleteBlogs(int id);
        //Zeiado

        // tarek
        // Diet Plan management
        void AddDietPlan(DietPlans dietPlan);
        IEnumerable<DietPlans> GetAllDietPlans();
        T GetDietPlanById(int id);
        void DeleteDietPlan(int id);
        //tarek

        // Admin Management(GET method)
        T AdminsManagement();

        T ShowSystemAnalytics();
        // Feedback Management
        T GetAllFeedback();

    }
}
