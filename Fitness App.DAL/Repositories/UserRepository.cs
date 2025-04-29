using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.BL.Interfaces;

namespace Fitness_App.DAL.Repositories
{
    internal class UserRepository<T> : IUserRepository<T> where T :class
    {
        public T ChangePassword(T user)
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

        public T UpdateProfile(T user)
        {
            throw new NotImplementedException();
        }
    }
}
