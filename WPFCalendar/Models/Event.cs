using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalendar.Models.enums;

namespace WPFCalendar.Models
{
    class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public EventType Type { get; set; }
        public Notifications Notifications { get; set; }
        public DateTime Time { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
