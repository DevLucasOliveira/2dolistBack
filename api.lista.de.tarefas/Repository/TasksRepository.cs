using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoWebApi.Interfaces;
using todoWebApi.Models;

namespace todoWebApi.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly TasksContext _context;

        public TasksRepository(TasksContext ctx)
        {
            _context = ctx;
        }

        public void Add(Tasks task)
        {
            _context.tasks.Add(task);
            _context.SaveChanges();
        }

        public Tasks Find(long id)
        {
            return _context.tasks.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<Tasks> GetAll()
        {
            return _context.tasks.ToList();
        }

        public void Remove(long id)
        {
            try
            {
                var entity = _context.tasks.First(u => u.Id == id);
                _context.tasks.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        public void Update(Tasks task)
        {
            _context.tasks.Update(task);
            _context.SaveChanges();
        }


    }
}
