using System;

namespace Alarm
{
    public class ChatReminderItem : ReminderItem
    {
        public string ChatName
        {
            get; set;
        }

        public string AccountName
        {
            get; set;
        }
        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine($"ChatName: {ChatName}");
            Console.WriteLine($"AccountName: {AccountName}");
        }
        public ChatReminderItem(string datetime, string chatname, string accountname, string message = "") :
            base(datetime, message)
        {
            ChatName = chatname;
            AccountName = accountname;

        }
    }
}
