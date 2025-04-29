using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Models;
using Fitness_App.DAL.Models;

namespace Fitness_App.BL.Interfaces
{
    public interface IClientRepository<T> : IUserRepository<T> where T : class

    {
        T AddProgressLog(ProgressLog progressLog);
        T GetProgressLogs();
        T SubmitFeedback(Feedback feedback);
        T GetMyFeedbacks(int ClientId);
        T Subscribe(Subscription subscription);
        T Unsubscribe(Subscription subscription);

        T CalculateCalories();
    }
}
