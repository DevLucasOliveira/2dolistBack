using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoWebApi.Models;

namespace todoWebApi.Interfaces
{
    public interface ITasksRepository
    {
        void Add(Tasks task);
        IEnumerable<Tasks> GetAll();
        Tasks Find(long id);
        void Remove(long id);
        void Update(Tasks task);
    
    }
}
