using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.DAL.Models;

namespace Fitness_App.BL.Interfaces
{
    public interface ICoachRepository<T> : IUserRepository<T>  where T : class
        
    {
        T SendMessage(Message message);//pending
        T GetSubscribedClient();
    }
}
