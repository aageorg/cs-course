using System;
using System.Reflection;

namespace Alarm
{
    public class ReminderItem
    {
        public TimeSpan TimeToAlarm
        {
            get => AlarmDate - DateTimeOffset.Now;
        }
        public bool IsOutdated
        {
            get
            {
                return (TimeToAlarm.Seconds < 0);
            }
        }

        public DateTimeOffset AlarmDate
        {
            get; set;         
        }

        public string AlarmMessage
        {
            get; set;
        }


        public virtual void WriteProperties()
        {
            Console.WriteLine("");
            Console.WriteLine($"Type of the object: {this.GetType()}");
            foreach (PropertyInfo prop in typeof(ReminderItem).GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this)}");
            }
            
        }
        public ReminderItem(string datetime, string message  = "")
        {
            if (!DateTimeOffset.TryParse(datetime, out DateTimeOffset alarmdate)) {
                throw new ArgumentException ("Cannot parse the date of alarm value");
            }
            AlarmDate = alarmdate;
            if (string.IsNullOrWhiteSpace(message))
            {
                AlarmMessage = "No message for this alarm";
            }

        else
            {
                AlarmMessage = message;
            }
               
        }

    }
}
