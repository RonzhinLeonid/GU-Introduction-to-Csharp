using System;
using System.Collections.Generic;
using System.Text;

namespace Les5Ex5Core
{
    class ToDoList
    {
        private static int number = 0;
        public int Number { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDoList()
        {
            Number = ++number;
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
