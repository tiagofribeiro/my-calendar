using MahApps.Metro.IconPacks;
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
    /// Interação lógica para componente de botão redondo
    /// </summary>
    public partial class RoundButton : UserControl
    {
        // DependencyProperty - propriedades dependentes de um controle
        public static readonly DependencyProperty ButtonIconProperty = DependencyProperty.Register(
                name: "ButtonIcon",
                propertyType: typeof(PackIconFontAwesomeKind),
                ownerType: typeof(RoundButton),
                typeMetadata: new PropertyMetadata(PackIconFontAwesomeKind.None));

        // Propriedades
        public PackIconFontAwesomeKind ButtonIcon
        {
            get { return (PackIconFontAwesomeKind)GetValue(ButtonIconProperty); }
            set { SetValue(ButtonIconProperty, value); }
        }

        // RoutedEvents - eventos dinâmicos (propagados para a árvore de elementos) de um controle
        public static readonly RoutedEvent RoundButtonClickEvent = EventManager.RegisterRoutedEvent(
            name: "RoundButtonClick",
            routingStrategy: RoutingStrategy.Bubble,
            handlerType: typeof(RoutedEventHandler),
            ownerType: typeof(SimpleButton));

        // Handler
        public event RoutedEventHandler RoundButtonClick
        {
            add { AddHandler(RoundButtonClickEvent, value); }
            remove { RemoveHandler(RoundButtonClickEvent, value); }
        }

        public RoundButton()
        {
            InitializeComponent();
        }

        // Click
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(RoundButtonClickEvent));
        }
    }
}
