using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seatwork_3._9_02
{
    public delegate void ClockHandler(object sender);
    public class Clock
    {   public event ClockHandler AlarmEvent;
        public event ClockHandler TickEvent;
        private int aHour;
        private int aMinute;
        private int aSecond;
        public void setAlarm(int hour,int minute,int second)
        {
            aHour = hour;
            aMinute = minute;
            aSecond = second;
        }
        public void isAlarm(object sender) { Console.WriteLine("闹钟响了。"); }
        public void isTick(object sender) { Console.WriteLine("闹钟在走。"); }
        public  Clock()
        {
            AlarmEvent += isAlarm;
            TickEvent += isTick;
        }
        public void startWork()
        {
            for(; ; )
            {
                TickEvent(this);
                Thread.Sleep(1000);
            if (DateTime.Now.Hour == aHour && DateTime.Now.Minute == aMinute && DateTime.Now.Second == aSecond)
                {
                    AlarmEvent(this);
                    break;
                }       
            }      
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.setAlarm(10, 58, 1);
            myClock.startWork();
        }
    }
}
