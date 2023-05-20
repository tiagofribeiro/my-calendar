using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFCalendar.Models.enums;
using WPFCalendar.ViewModels;

namespace WPFCalendar.Views
{
    /// <summary>
    /// Interação lógica para TaskView.xam
    /// </summary>
    public partial class TaskView : UserControl
    {
        private static readonly TasksViewModel _context = new TasksViewModel();
        private static readonly Dictionary<TaskType, SolidColorBrush> _tagColors = new Dictionary<TaskType, SolidColorBrush>
            {
                { TaskType.Personal, (SolidColorBrush)Application.Current.Resources["TagColor1"] },
                { TaskType.Profissional, (SolidColorBrush)Application.Current.Resources["TagColor2"] },
                { TaskType.Health, (SolidColorBrush)Application.Current.Resources["TagColor3"] },
                { TaskType.House, (SolidColorBrush)Application.Current.Resources["TagColor4"] },
                { TaskType.Pet, (SolidColorBrush)Application.Current.Resources["TagColor5"] },
                { TaskType.Gov, (SolidColorBrush)Application.Current.Resources["TagColor6"] }
            };

        public static SolidColorBrush TagColor
        {
            get { return (SolidColorBrush)Application.Current.Resources["TagColor1"]; }
        }


        public TaskView()
        {
            InitializeComponent();
            DataContext = _context;
            Debug.WriteLine(_context.Tasks[0].Type);
        }
    }
}
