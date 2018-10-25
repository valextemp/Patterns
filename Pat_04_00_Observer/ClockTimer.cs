using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_04_00_Observer
{
    class ClockTimer:Subject
    {
        System.Threading.Timer timer;
        private TimeSpan currentTime;

        public void Tick()
        {
            currentTime = DateTime.Now.TimeOfDay;
            Notify();
        }

        static void TimerProc(object o)
        {
            (o as ClockTimer).Tick();
        }

        public ClockTimer()
        {
            timer = new System.Threading.Timer(TimerProc, this, 1000, 1000);
        }

        public int GetHour()
        {
            return currentTime.Hours;
        }

        public int GetMenute()
        {
            return currentTime.Minutes;
        }

        public int GetSecond()
        {
            return currentTime.Seconds;
        }
        public TimeSpan GetTime()
        {
            return currentTime;
        }

    }
}
