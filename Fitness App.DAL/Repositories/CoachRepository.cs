using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Interfaces;
using Fitness_App.DAL.Models;

namespace Fitness_App.DAL.Repositories
{
    internal class CoachRepository<T> : ICoachRepository<T> where T : class
    {
        public T ChangePassword(T user)
        {
            throw new NotImplementedException();
        }

        public T GetSubscribedClient()
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

        public T SendMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public T UpdateProfile(T user)
        {
            throw new NotImplementedException();
        }
    }
}
