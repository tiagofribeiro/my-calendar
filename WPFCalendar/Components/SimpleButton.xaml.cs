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
        // DependencyProperty - propriedades dinâmicas (dependentes) de um controle
        public static readonly DependencyProperty ButtonTextProperty = DependencyProperty.Register(
                name: "ButtonText",
                propertyType: typeof(string),
                ownerType: typeof(SimpleButton),
                typeMetadata: new PropertyMetadata("ButtonText"));

        // Propriedades
        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        // RoutedEvents - eventos dinâmicos (propagados para a árvore de elementos) de um controle
        public static readonly RoutedEvent ButtonClickEvent = EventManager.RegisterRoutedEvent(
            name: "ButtonClick",
            routingStrategy: RoutingStrategy.Bubble,
            handlerType: typeof(RoutedEventHandler),
            ownerType: typeof(SimpleButton));

        // Handler
        public event RoutedEventHandler ButtonClick
        {
            add { AddHandler(ButtonClickEvent, value); }
            remove { RemoveHandler(ButtonClickEvent, value); }
        }


        // Construtor
        public SimpleButton()
        {
            InitializeComponent();
        }

        // Click
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ButtonClickEvent));
        }
    }
}
