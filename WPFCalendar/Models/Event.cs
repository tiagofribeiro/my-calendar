using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalendar.Models.enums;

namespace WPFCalendar.Models
{
    /// <summary>
    /// Objeto de Eventos.
    /// Dados manipulados na construção do calendário e no gerenciamento de notificações.
    /// </summary>
    class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public EventType Type { get; set; }
        public Notifications Notifications { get; set; }
        public DateTime Time { get; set; }
        public DateTime Created { get; set; }

        public Event(int id, string name, string? description, string? location, EventType type, Notifications notifications, DateTime time)
        {
            Id = id;
            Name = name;
            Description = description;
            Location = location;
            Type = type;
            Notifications = notifications;
            Time = time;
            Created = DateTime.Now;
        }
    }
}
