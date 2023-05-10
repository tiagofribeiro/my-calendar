using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalendar.Models.enums;

namespace WPFCalendar.ViewModels
{
    class TasksViewModel : BaseNotifyPropertyChange
    {
        // Lista "temporária" de Tarefas
        public ObservableCollection<Models.Task> Tasks { get; set; } = new ObservableCollection<Models.Task>();

        private Models.Task _selectedTask;
        public Models.Task SelectedTask
        {
            get { return _selectedTask; }
            set { SetField(ref _selectedTask, value); }
        }

        public TasksViewModel()
        {
            Tasks = new ObservableCollection<Models.Task>
            {
                new Models.Task(
                    id: 1,
                    name: "Tarefa",
                    subtasks: new List<string>()
                    {
                        "Subtarefa 1",
                        "Subtarefa 2"
                    },
                    notifications: new List<Notifications>()
                    {
                        Notifications.ThreeHours,
                        Notifications.OneDay
                    },
                    type: TaskType.Personal,
                    deadline: DateTime.Now
                )
            };

            SelectedTask = Tasks.FirstOrDefault();
        }
    }
}
