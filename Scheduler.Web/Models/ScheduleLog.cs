using System;

namespace Scheduler.Web.Models
{
    public class ScheduleLog
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public DateTime ExecutionTime { get; set; }
        public string Result { get; set; }
    }

    public class ScheduleRecord
    {
        public ScheduleItem Item { get; set; }
        public ScheduleLog Log { get; set; }
    }
}
