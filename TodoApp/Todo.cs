using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Todo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public override string ToString()
        {
            return ID + ". " + Name;
        }

    }
}
