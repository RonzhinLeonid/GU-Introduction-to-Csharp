using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les5Ex5
{
    public class ToDoList
    {
        private static int number = 0;
        public int Number { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDoList()
        {
            Number = ++number;
            Title = "11";
            IsDone = false;
        }
        public ToDoList(string title, bool isDone)
        {
            Number = ++number;
            Title = title;
            IsDone = isDone;
        }

        public override string ToString()
        {
            if (IsDone)
                return Number + " [x] " + Title;
            else
                return Number + " [ ] " + Title;
        }
    }
}
