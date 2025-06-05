using System;
using System.Linq;
using System.Web.Mvc;
using Scheduler.Web.Models;

namespace Scheduler.Web.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        private ScheduleContext db = new ScheduleContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ScheduleItem model)
        {
            if (ModelState.IsValid)
            {
                if (model.IsImmediate)
                {
                    model.ScheduledTime = DateTime.Now;
                }
                db.Schedules.Add(model);
                db.SaveChanges();
                db.Logs.Add(new ScheduleLog
                {
                    ScheduleId = model.Id,
                    ExecutionTime = model.ScheduledTime,
                    Result = "Scheduled"
                });
                db.SaveChanges();
                return RedirectToAction("History");
            }
            return View(model);
        }

        public ActionResult History()
        {
            var records = from item in db.Schedules
                          join log in db.Logs on item.Id equals log.ScheduleId
                          select new ScheduleRecord { Item = item, Log = log };
            return View(records.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
