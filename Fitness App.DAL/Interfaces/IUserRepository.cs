using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.DAL.Models;

namespace Fitness_App.BL.Interfaces
{
    public interface IUserRepository<T> where T : class
    {
        T Login(string Email, string Password);
        T Logout(string FName, string LName, string Password);
        T UpdateProfile(T user);
        T ChangePassword(T user);
        T Register(T user);
    }
}
