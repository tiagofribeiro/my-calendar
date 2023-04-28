using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalendar.Models.enums;

namespace WPFCalendar.Models
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public TaskType Type { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime? Deadline { get; set; }

    }
}
