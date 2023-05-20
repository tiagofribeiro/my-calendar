using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WPFCalendar.Functions;
using WPFCalendar.Models.enums;

namespace WPFCalendar.ViewModels
{
    class TasksViewModel : BaseNotifyPropertyChange
    {
        // Lista "temporária" de Tarefas
        public ObservableCollection<Models.Task> Tasks { get; set; } = new ObservableCollection<Models.Task>();

        private Models.Task? _selectedTask;

        public Models.Task? SelectedTask
        {
            get => _selectedTask;
            set => SetField(ref _selectedTask, value);
        }

        public TasksViewModel()
        {
            Tasks = new ObservableCollection<Models.Task>
            {
                new Models.Task(
                    id: 1,
                    name: "Tarefa de teste",
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
                ),
                new Models.Task(
                    id: 2,
                    name: "Tarefa de teste 2",
                    subtasks: new List<string>()
                    {
                        "Subtarefa 3",
                        "Subtarefa 4",
                        "Subtarefa 5",
                        "Subtarefa 6",
                        "Subtarefa 7",
                    },
                    notifications: new List<Notifications>()
                    {
                        Notifications.ThreeHours,
                        Notifications.OneDay
                    },
                    type: TaskType.Health,
                    deadline: DateTime.Parse("20/05/2023 19:00")
                ),
                new Models.Task(
                    id: 3,
                    name: "Tarefa de teste 3",
                    subtasks: new List<string>()
                    {
                        "Subtarefa 8",
                        "Subtarefa 9"
                    },
                    notifications: new List<Notifications>()
                    {
                        Notifications.ThreeHours,
                        Notifications.OneDay
                    },
                    type: TaskType.Gov,
                    deadline: DateTime.Parse("15/06/2023")
                )
            };

            SelectedTask = Tasks.Count > 0 ? Tasks.FirstOrDefault() : null;
            Debug.WriteLine(SelectedTask.Name);
        }
    }
}
