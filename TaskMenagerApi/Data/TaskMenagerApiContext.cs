using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskMenagerApi;

namespace TaskMenagerApi.Data
{
    public class TaskMenagerApiContext : DbContext
    {
        public TaskMenagerApiContext (DbContextOptions<TaskMenagerApiContext> options)
            : base(options)
        {
        }

        public DbSet<TaskMenagerApi.Task> Task { get; set; } = default!;
    }
}
