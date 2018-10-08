using System;

namespace Program1
{
    public delegate void AlarmClock(object sender); //委托

    public class SetClock
    {
        public string Hour { get; set; }

        public string Minute { get; set; }

        public string Second { get; set; }
    }

    public class MyClock
    {
        public event AlarmClock Clock; //事件

        private bool onTime;

        public string Hour { get; set; }

        public string Minute { get; set; }

        public string Second { get; set; }

        public bool GetOnTime()
        {
            return onTime;
        }

        public void SetOnTime(bool value)
        {
            onTime = value;
        }

        public void Ring(string a, string b, string c) //响铃
        {
            var args = new SetClock
            {
                Hour = a,
                Minute = b,
                Second = c
            };
            while (true)
            {
                var dateNowHour = DateTime.Now.Hour.ToString();
                var dateNowMinute = DateTime.Now.Minute.ToString();
                var dateNowSecond = DateTime.Now.Second.ToString();

                if (dateNowHour.Equals(a) && dateNowMinute.Equals(b) && dateNowSecond.Equals(c)) break;
            }

            Clock?.Invoke(this);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var clock = new MyClock();
            Console.WriteLine("请输入闹钟时间：");
            try
            {
                Console.WriteLine("小时：");
                clock.Hour = Console.ReadLine();
                Console.WriteLine("分钟：");
                clock.Minute = Console.ReadLine();
                ;
                Console.WriteLine("秒钟：");
                clock.Second = Console.ReadLine();
                ;
            }
            catch
            {
                // ignored
            }

            clock.Clock += Clock;
            clock.Ring(clock.Hour, clock.Minute, clock.Second);
        }

        private static void Clock(object sender)
        {
            Console.WriteLine("\n时间到！\n\a");
            Console.ReadKey();
        }
    }
}