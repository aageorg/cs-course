using System;

namespace Alarm
{
    public class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber
        {
            get; set;
        }
        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine($"PhoneNumber: {PhoneNumber}");
        }
        public PhoneReminderItem(string datetime, string phone, string message = "") : 
            base(datetime, message)
        {
            PhoneNumber = phone;
        }
    }
}
