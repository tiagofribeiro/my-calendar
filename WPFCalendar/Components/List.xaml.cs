using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFCalendar.Models;

namespace WPFCalendar.Components
{
    /// <summary>
    /// Interação lógica para lista
    /// </summary>
    public partial class List : UserControl
    {
        private static readonly DependencyProperty ListDataProperty = DependencyProperty.Register(
            name: "ListData",
            propertyType: typeof(ObservableCollection<Subtask>),
            ownerType: typeof(List),
            typeMetadata: new PropertyMetadata(new ObservableCollection<Subtask>()));

        public ObservableCollection<Subtask> ListData
        {
            get { return (ObservableCollection<Subtask>)GetValue(ListDataProperty); }
            set { SetValue(ListDataProperty, value); }
        }

        private static readonly DependencyProperty HideCheckProperty = DependencyProperty.Register(
            name: "HideCheck",
            propertyType: typeof(bool),
            ownerType: typeof(List),
            typeMetadata: new FrameworkPropertyMetadata(false, new PropertyChangedCallback(HideCheck_Changed)));

        public bool HideCheck
        {
            get { return (bool)GetValue(HideCheckProperty); }
            set { SetValue(HideCheckProperty, value); }
        }

        public List()
        {
            InitializeComponent();
        }

        private static void HideCheck_Changed(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            List list = (List)obj;
            Debug.WriteLine(list);
            Debug.WriteLine(e.NewValue);
            Debug.WriteLine(e.OldValue);
            Debug.WriteLine("------------------------");
        }

    }
}
