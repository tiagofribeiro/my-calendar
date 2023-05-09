using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalendar.Models.enums;

namespace WPFCalendar.Models
{   
    /// <summary>
    /// Objeto de Timer.
    /// Manipula os tempos realizados no Pomodoro/Cronômetro.
    /// </summary>
    class Timer
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public TimerType Type { get; set; }
        public TimeSpan ActiveTime { get; set; }
        public TimeSpan BreakTime { get; set; }
        public DateTime Created { get; set; }

        public Timer(int id, int taskId, TimerType type, TimeSpan activeTime, TimeSpan breakTime)
        {
            Id = id;
            TaskId = taskId;
            Type = type;
            ActiveTime = activeTime;
            BreakTime = breakTime;
            Created = DateTime.Now;
        }
    }
}
