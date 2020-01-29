using BEProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEProject.Data
{
    public class BaseMainContext : DbContext
    {
        public BaseMainContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TodoList> TodoListSet { get; set; }
    }
}