using System;
using System.Reflection;

namespace Alarm
{
    class ReminderItem
    {
        private DateTimeOffset _alarmDate;
        private string _alarmMessage;

        public TimeSpan TimeToAlarm
        {
            get => AlarmDate - DateTimeOffset.Now;
        }
        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm.Seconds > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public DateTimeOffset AlarmDate
        {
            get => _alarmDate;
            set
            {
                _alarmDate = value;
            }               
            
        }

        public string AlarmMessage
        {
            get => _alarmMessage;
            set
            {
                _alarmMessage = value;
            }
        }


        public void WriteProperties()
        {
            foreach (PropertyInfo prop in typeof(ReminderItem).GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this)}");
            }
            Console.WriteLine("");
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
