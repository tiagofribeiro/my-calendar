using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WPFCalendar.Functions;

namespace WPFCalendar.ViewModels
{
    internal class EventViewModel : BaseNotifyPropertyChange
    {
        // Lista "temporária" de Eventos
        public ObservableCollection<Models.Event> Events { get; set; } = new ObservableCollection<Models.Event>();

        private Models.Event? _selectedEvent;
        public Models.Event SelectedEvent
        {
            get => _selectedEvent;
            set => SetField(ref _selectedEvent, value);
        }
    }
}
