using System;
namespace Abstraction
{
    public abstract class MessagingService
    {
        public abstract void Sendmsg(string Name, string Message);
    }

    public class Sms : MessagingService
    {
        public override void Sendmsg(string Name, string Message)
        {
            Console.WriteLine($"Name of the Sender is {Name} and message is --> {Message}");
        }
    }
    public class Whatsapp : MessagingService
    {
        public override void Sendmsg(string Name, string Message)
        {
            Console.WriteLine($"Contact Name is {Name} and message is {Message}");
        }
    }
    public class Insta : MessagingService
    {
        public override void Sendmsg(string Name, string Message)
        {
            Console.WriteLine($"account name is {Name} and message is {Message}");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            MessagingService sms = new Sms();
            MessagingService whatsapp = new Whatsapp();
            MessagingService insta = new Insta();

            MsgService(sms, "Sarb", "hy");
            MsgService(whatsapp, "Kalpana", "hello");
            MsgService(insta, "khushi", "hi");


        }
        static void  MsgService(MessagingService service, string name, string message)
        {
            service.Sendmsg(name, message);
    }
    }
}