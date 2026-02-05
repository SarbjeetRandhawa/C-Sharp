using System;
using System.Security.Cryptography.X509Certificates;
namespace Abstraction
{
    public interface IMessaging
    {
         void Sendmessage(string name , string message);
    }
    public class Sms: IMessaging
    {
        public void Sendmessage(string name , string message)
        {
            Console.WriteLine($"name is {name} and message is {message}");
        }
    }
    public class Insta : IMessaging
    {
        public void Sendmessage(string name , string message)
        {
            Console.WriteLine($"name is {name} and message is {message}");
        }
    } 

     class Program
    {
        public static void Main()
        {
            IMessaging sms = new Sms();
            IMessaging insta = new Insta();

            sendalert(sms, "Sarbjeet", "Hello");

            sendalert(sms, "Mona", "bye");
        }

        static void sendalert(IMessaging service , string name , string message)
        {
            service.Sendmessage(name, message);
        }
    }
    
}