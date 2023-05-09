using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalendar.Models.enums;

namespace WPFCalendar.Models
{
    /// <summary>
    /// Objeto de Tarefa.
    /// Dados manipulados na construção da lista de tarefas e no gerenciamento de notificações.
    /// </summary>
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string>? Subtasks { get; set; }
        public TaskType Type { get; set; }
        public Notifications Notifications { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime Created { get; set; }

        public Task(int id, string name, List<string>? subtasks, TaskType type, Notifications notifications , DateTime? deadline)
        {
            Id = id;
            Name = name;
            Subtasks = subtasks;
            Type = type;
            Notifications = notifications;
            Deadline = deadline;
            Created = DateTime.Now;
        }

    }
}
