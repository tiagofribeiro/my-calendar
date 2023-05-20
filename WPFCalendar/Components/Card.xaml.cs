using System;
using System.Collections.Generic;
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

namespace WPFCalendar.Components
{
    /// <summary>
    /// Interação lógica para componente base de Card.
    /// </summary>
    public partial class Card : UserControl
    {

        private static Color _defaultColor = (Color)ColorConverter.ConvertFromString("#dadfe8");

        public static readonly DependencyProperty CardColorProperty = DependencyProperty.Register(
            name: "CardColor",
            propertyType: typeof(SolidColorBrush),
            ownerType: typeof(Card),
            typeMetadata: new PropertyMetadata(new SolidColorBrush(_defaultColor)));

        public SolidColorBrush CardColor
        {
            get { return (SolidColorBrush)GetValue(CardColorProperty); }
            set { SetValue(CardColorProperty, value); }
        }

        public Card()
        {
            InitializeComponent();

        }
    }
}
