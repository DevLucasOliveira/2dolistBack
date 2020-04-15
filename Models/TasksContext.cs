using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace todoWebApi.Models
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options)
            : base(options)
        { }

        public DbSet<Tasks> tasks { get; set; }

   
    }
}
