using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics.Contracts;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //           ReminderItem alarm1 = new ReminderItem("31.12.2020 23:20", "RUN!!!");
            //           ReminderItem alarm2 = new ReminderItem("20.09.2020 10:00", "Do something");
            //           alarm1.WriteProperties();
            //           alarm2.WriteProperties();

            ReminderItem[] reminders = new ReminderItem[]
            {
                new ReminderItem("10.12.2020 17:20"),
                new PhoneReminderItem("12.10.2020 19:00", "+79153376045", "Lesson"),
                new ChatReminderItem("12.10.2020", "Telegram", "@feyadindin", "Conference call")
            };
            
            foreach (ReminderItem reminder in reminders)
            {
                reminder.WriteProperties();
            }

            
    /* 
    Output:

    Type of the object: Alarm.ReminderItem
    TimeToAlarm: 60.23:42:53.6954934
    IsOutdated: False
    AlarmDate: 10.12.2020 17:20:00 +03:00
    AlarmMessage: No message for this alarm

    Type of the object: Alarm.PhoneReminderItem
    TimeToAlarm: 2.01:22:53.6914932
    IsOutdated: False
    AlarmDate: 12.10.2020 19:00:00 +03:00
    AlarmMessage: Lesson
    PhoneNumber: +79153376045

    Type of the object: Alarm.ChatReminderItem
    TimeToAlarm: 1.06:22:53.6904931
    IsOutdated: False
    AlarmDate: 12.10.2020 0:00:00 +03:00
    AlarmMessage: Conference call
    ChatName: Telegram
    AccountName: @feyadindin

    */
        }
    }
}
