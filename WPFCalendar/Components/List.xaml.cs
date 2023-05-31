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
    /// Interação lógica para List.xam
    /// </summary>
    public partial class List : UserControl
    {
        public static readonly DependencyProperty ListDataProperty = DependencyProperty.Register(
            name: "ListData",
            propertyType: typeof(ObservableCollection<Subtask>),
            ownerType: typeof(List),
            typeMetadata: new PropertyMetadata(new ObservableCollection<Subtask>()));

        public ObservableCollection<Subtask> ListData
        {
            get { return (ObservableCollection<Subtask>)GetValue(ListDataProperty); }
            set { SetValue(ListDataProperty, value); }
        }

        public List()
        {
            InitializeComponent();
        }
    }
}
