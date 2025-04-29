using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Interfaces;
using Fitness_App.BL.Models;
using Fitness_App.DAL.Models;

namespace Fitness_App.DAL.Repositories
{
    internal class ClientRepository<T> : IClientRepository<T> where T : class
    {
        public T AddProgressLog(ProgressLog progressLog)
        {
            throw new NotImplementedException();
        }

        public T CalculateCalories()
        {
            throw new NotImplementedException();
        }

        public T ChangePassword(T user)
        {
            throw new NotImplementedException();
        }

        public T GetMyFeedbacks(int ClientId)
        {
            throw new NotImplementedException();
        }

        public T GetProgressLogs()
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

        public T SubmitFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public T Subscribe(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public T Unsubscribe(Subscription subscription)
        {
            throw new NotImplementedException();
        }

        public T UpdateProfile(T user)
        {
            throw new NotImplementedException();
        }
    }
}
