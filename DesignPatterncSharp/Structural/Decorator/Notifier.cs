using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace DesignPatterncSharp.Structural.Decorator
{
    public interface INotifier
    {
        void Send();
    }

    public class Sms : INotifier
    {
        public void Send()
        {
            Console.WriteLine("sending sms");
        }
    }

    public class mail : INotifier
    {
        public void Send()
        {
            Console.WriteLine("sending mail");
        }
    }

    public class SlackMsg : INotifier
    {
        public void Send()
        {
            Console.WriteLine("sending SlackMsg");
        }
    }

    public class SmsDecorator : Sms
    {

       
        private readonly INotifier notifier;
        public SmsDecorator( INotifier notifier)
        {
           
        }

        public new void Send()
        {
            base.Send();
            this.notifier.Send();
        }
    }
    public class SlackDecorator : SlackMsg
    {

        
        private readonly INotifier notifier;
        public SlackDecorator( INotifier notifier)
        {
            this.notifier = notifier;
        }

        public new void Send()
        {
            base.Send();
            this.notifier.Send();
        }
    }

    public class MailDecorator : mail, INotifier
    {

  
        private readonly INotifier notifier;
        public MailDecorator( INotifier notifier)
        {
            this.notifier = notifier;

        }

        public new void Send()
        {
            base.Send();
            this.notifier.Send();
        }
    }

    static class main
    {
        static void Main(string[] args)
        {
            INotifier notifier = new Sms();

            notifier = new SlackDecorator(notifier);
            notifier = new MailDecorator(notifier);

            notifier.Send();
            // this method will first send mail, then slack then sms

        }

    }
}
