using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalendar.Models
{
    /// <summary>
    /// Objeto de notificação.
    /// Manipula as notificações programadas.
    /// </summary>
    class Notification
    {
        public int Id { get; set; }
        public object Reference { get; set; }
        public DateTime Alert { get; set; }

        public Notification(int id, object reference, DateTime alert)
        {
            Id = id;
            Reference = reference;
            Alert = alert;
        }
    }
}
