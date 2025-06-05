using System;
using System.ComponentModel.DataAnnotations;

namespace Scheduler.Web.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsImmediate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ScheduledTime { get; set; }
    }
}
