using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Media;
using WPFCalendar.Functions;
using WPFCalendar.Models.enums;

namespace WPFCalendar.ViewModels
{
    class TasksViewModel : BaseNotifyPropertyChange
    {
        // Lista "temporária" de Tarefas
        public ObservableCollection<Models.Task> Tasks { get; set; } = new ObservableCollection<Models.Task>();

        public TasksViewModel()
        {
            Tasks = new ObservableCollection<Models.Task>
            {
                new Models.Task(
                    id: 1,
                    name: "Tarefa de teste",
                    subtasks: new ObservableCollection<Models.Subtask>()
                    {
                        new Models.Subtask() { Name="Subtarefa 1", IsChecked=true },
                        new Models.Subtask() { Name="Subtarefa 2", IsChecked=false }
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
                    subtasks: new ObservableCollection<Models.Subtask>()
                    {
                        new Models.Subtask() { Name="Subtarefa 3", IsChecked=true },
                        new Models.Subtask() { Name="Subtarefa 4", IsChecked=true },
                        new Models.Subtask() { Name="Subtarefa 5", IsChecked=false },
                        new Models.Subtask() { Name="Subtarefa 6", IsChecked=true },
                        new Models.Subtask() { Name="Subtarefa 7", IsChecked=true },
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
                    subtasks: new ObservableCollection<Models.Subtask>()
                    {
                        new Models.Subtask() { Name="Subtarefa 8", IsChecked=false },
                        new Models.Subtask() { Name="Subtarefa 9", IsChecked=true },
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

            //SelectedTask = Tasks.Count > 0 ? Tasks.FirstOrDefault() : null;
        }
    }
}
