using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapmlePrj.Observe
{
    public static class ObserveClient
    {
        public static void Run()
        {
            IObject subject = new Subject();
            subject.AddMonitor(new Monitor(subject, "Monitor_1"));
            subject.AddMonitor(new Monitor(subject, "Monitor_2"));
            subject.AddMonitor(new Monitor(subject, "Monitor_3"));

            subject.SubjectState = "Start!";
            subject.SendMessage();
        }
    }
}
