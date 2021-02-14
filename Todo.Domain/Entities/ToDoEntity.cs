using System;

namespace Todo.Domain.Entities
{
    public class ToDoEntity : Entity
    {
        public ToDoEntity(string title, string refUser, DateTime date)
        {
            Title = title;
            IsDone = false;
            Date = date;
            RefUser = refUser;
        }

        public string Title { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime Date { get; private set; }
        public string RefUser { get; private set; }

        public void MarkAsDone()
        {
            IsDone = true;
        }
        public void MarkAsUnDone()
        {
            IsDone = true;
        }
        public void UpdateTitle(string title)
        {
            Title = title;
            //validação
        }
    }
}