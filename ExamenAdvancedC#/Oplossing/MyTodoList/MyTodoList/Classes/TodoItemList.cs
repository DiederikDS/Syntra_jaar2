using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoList
{
    public class TodoItemList<T> where T : TodoItem
    {
        public List<T> TodoItems { get; set; }

        public TodoItemList()
        {
            TodoItems = new List<T>();
        }

        public void Add(T todo)
        {
            TodoItems.Add(todo);
        }

        public List<string> GetGroupedTodosPerWeek()
        {
            return TodoItems.GroupBy(e => new { Monday = e.DueDate.Date.AddDays(-(int)e.DueDate.Date.DayOfWeek + (int)DayOfWeek.Monday) })
                            .Select(e => e.Key.Monday.ToShortDateString() + "-" + e.Key.Monday.AddDays(6).ToShortDateString() + ": " + e.Count())
                            .ToList();
        }

        public List<string> GetGroupedPerExecuter()
        {
            return TodoItems.GroupBy(e => e.ExecuterName)
                            .Select(e => e.Key + ": " + e.Count())
                            .ToList();
        }

        public List<string> GetExecutedTodos()
        {
            return TodoItems.Where(e => e.ExecutedDate != DateTime.MinValue)
                            .Select(e => e.ExecutedDate.ToString() + " -> " + e.Name + ": "+ e.Description)
                            .ToList();
        }

        public List<string> GetAllTodoUpcomingWeek()
        {
            return TodoItems.Where(e => e.DueDate <= DateTime.Now.AddDays(7) && e.ExecutedDate == DateTime.MinValue)
                            .Select(e => e.Name + ": " + e.Description)
                            .ToList();
        }
    }
}
