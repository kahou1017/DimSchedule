using System.Data.Entity;

namespace Scheduler.Web.Models
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext() : base("ScheduleContext")
        {
        }

        public DbSet<ScheduleItem> Schedules { get; set; }
        public DbSet<ScheduleLog> Logs { get; set; }
    }
}
