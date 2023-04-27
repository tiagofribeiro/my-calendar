using System;
using System.Collections.Generic;
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

namespace WPFCalendar.Components
{
    /// <summary>
    /// Interação lógica para SimpleButton.xaml
    /// </summary>
    public partial class SimpleButton : UserControl
    {
        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public static readonly DependencyProperty ButtonTextProperty = 
            DependencyProperty.Register("ButtonText", typeof(string), typeof(SimpleButton), new PropertyMetadata("ButtonText"));


        public SimpleButton()
        {
            InitializeComponent();
        }
    }
}
