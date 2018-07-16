using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class TodoContext :DbContext // using system.data.entity
    {
        public TodoContext() : base() // means run dbcontext base constructor //is required
        {
        }
        public DbSet<Todo> Todos { get; set; } // creates a propterty kinda like a list kkinda like a table is the property that stores the list of todo classes
    }
}
