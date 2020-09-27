using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.Contracts;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            ReminderItem alarm1 = new ReminderItem("31.12.2020 23:20", "RUN!!!");
            ReminderItem alarm2 = new ReminderItem("20.09.2020 10:00", "Do something");
            ReminderItem alarm3 = new ReminderItem("10.10.2020 17:20");

            alarm1.WriteProperties();
            alarm2.WriteProperties();
            alarm3.WriteProperties();

        /* 
        Output:

        TimeToAlarm: 95.10:25:17.0217980
        IsOutdated: False
        AlarmDate: 31.12.2020 23:20:00 + 03:00
        AlarmMessage: RUN!!!


        TimeToAlarm: -7.02:54:43.1512119
        IsOutdated: True
        AlarmDate: 20.09.2020 10:00:00 + 03:00
        AlarmMessage: Do something


        TimeToAlarm: 13.04:25:16.8467880
        IsOutdated: False
        AlarmDate: 10.10.2020 17:20:00 + 03:00
        AlarmMessage: No message for this alarm
        */
        }
    }
}
