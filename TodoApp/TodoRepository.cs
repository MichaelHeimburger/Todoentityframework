using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoRepository
    {
        public List<Todo> GetAll() // method returns a list of todos todo class has to be public
        {
            using (var db = new TodoContext())
            {
                return db.Todos.ToList();
            }
        }

        public Todo GetById(int todoid)
        {
            using(var db = new TodoContext())
            {
                return db.Todos.Single(todo => todo.ID == todoid); // finds the todo witht he id we want
            }
        }

        public  void RemoveID(int todoid)
        {
            using (var db = new TodoContext())
            {
                var a = db.Todos.Single(todo => todo.ID == todoid);
                db.Todos.Remove(a);
                db.SaveChanges();
            }



        }

        public void AddToDo(string tdname, string tddetails)
        {
            using(var db = new TodoContext())
            {
                var Todo = new Todo();
                Todo.Name = tdname;
                Todo.Details = tddetails;
                db.Todos.Add(Todo);
                db.SaveChanges();
            }
        }
    }
}
