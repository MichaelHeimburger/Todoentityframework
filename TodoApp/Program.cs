using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            Console.WriteLine("Hello");
            //using (var db = new TodoContext()) // hangs up the connetion of access to the databse, is required?                                       // db is only used in the following context
            //{                                       // db is only used in this context

            //foreach (var item in db.Todos)
            //{ // comented out to replace with a class
           
                            // db is "disposed" meaning connection is ended. instead of using steatement an alternative could be declaring db and latter on using db.Dispose() if never disposed could cause memory errors
             while(loop)
            {
                Console.Clear();
                DisplayTodos();// code down there was made into a method
                Console.WriteLine("Select an option");
            Console.WriteLine("1. View Details of a Todo \n2. Remove a Todo \n3. Add a Todo\n4. Refresh list\n5. Leave app");
            var soption = Console.ReadLine();
            if (soption == "1")
            {
                Console.WriteLine("Which todo?");
                var selectedTodo = Console.ReadLine();
                DisplayTodoDetails(int.Parse(selectedTodo));
            }
            else if(soption == "2")
            {
                Console.WriteLine("Which todo?");
                var selectedTodo = Console.ReadLine();
                Removetodo(int.Parse(selectedTodo));

            }
            else if(soption == "3")
                {
                    Console.WriteLine("What do you want todo?");
                    var tdname = Console.ReadLine();
                    Console.WriteLine("Details?");
                    var tddetails = Console.ReadLine();
                    Addtodo(tdname, tddetails);
                }
            else if(soption == "4")
                {
                    DisplayTodos();
                    Console.WriteLine("enter to continue");
                    Console.ReadLine();
                }
            else if(soption == "5")
                {
                    loop = false;
                }
            }




        }

        private static void Addtodo(string tdname, string tddetails)
        {
            var todorepo = new TodoRepository();
            todorepo.AddToDo(tdname, tddetails);
        }

        private static void Removetodo(int todoid)
        {
            var todorepo = new TodoRepository();

            todorepo.RemoveID(todoid);

        }

        private static void DisplayTodoDetails(int todoid)
        {
            //get the todo print it out
            var todorepo = new TodoRepository();

            var todo = todorepo.GetById(todoid);
            Console.WriteLine(todo);
            Console.WriteLine(todo.Details);
        }
        private static void DisplayTodos()
        {
            var todorepo = new TodoRepository();
            foreach (var item in todorepo.GetAll())
            {
                Console.WriteLine(item.ToString()); // also could be Console.WriteLine(item) since by defualt it prints t
            }
        }
    }
}
