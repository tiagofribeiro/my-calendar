using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFCalendar.Components;
using WPFCalendar.Models.enums;
using WPFCalendar.ViewModels;

namespace WPFCalendar.Views
{
    /// <summary>
    /// Interação lógica para a View de tarefas
    /// </summary>
    public partial class TaskView : UserControl
    {
        // Contexto de dados - ViewModel
        private static readonly TasksViewModel _context = new TasksViewModel();

        // Dicionário de cores
        private static readonly Dictionary<TaskType, SolidColorBrush> _tagColors = new Dictionary<TaskType, SolidColorBrush>
            {
                { TaskType.Personal, (SolidColorBrush)Application.Current.Resources["TagColor1"] },
                { TaskType.Profissional, (SolidColorBrush)Application.Current.Resources["TagColor2"] },
                { TaskType.Health, (SolidColorBrush)Application.Current.Resources["TagColor3"] },
                { TaskType.House, (SolidColorBrush)Application.Current.Resources["TagColor4"] },
                { TaskType.Pet, (SolidColorBrush)Application.Current.Resources["TagColor5"] },
                { TaskType.Gov, (SolidColorBrush)Application.Current.Resources["TagColor6"] }
            };


        public TaskView()
        {
            InitializeComponent();
            DataContext = _context;
        }

        /// <summary>
        /// É acionado sempre que o componente é carregado na tela.
        /// </summary>
        /// <param name="sender">Componente</param>
        /// <param name="e">Argumentos de RoutedEvent</param>
        private void Card_Loaded(object sender, RoutedEventArgs e)
        {
            Card? card = (Card)sender;
            object? taskItem = (sender as FrameworkElement)?.DataContext;

            card.CardColor = _tagColors[key: (TaskType)taskItem.GetType().GetProperty("Type").GetValue(taskItem, null)];
        }
    }
}
