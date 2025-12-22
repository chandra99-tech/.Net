namespace ObserverPattern
{
    public delegate void NotifiyEventHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
           Publisher publisher = new Publisher();
           Subscriber subscriber = new Subscriber();

            publisher.Notifiy += subscriber.MethodA;
            publisher.Notifiy += subscriber.MethodB;

            publisher.NotifyHandler("The Grand Sale Is Live On Amazon Great Indain Sale");

            publisher.Notifiy -= subscriber.MethodB;

            publisher.NotifyHandler("Sale Upto 50-80% discount and Great Deals");
        }
    }

    public class Subscriber
    {
        public void MethodA(string message)
        {
            Console.WriteLine($"Message Receieved : {message} via SMS");
        }
        public void MethodB(string message)
        {
            Console.WriteLine($"Message Receieved : {message} via Email");
        }
    }

    public class Publisher
    {

        public event NotifiyEventHandler Notifiy;
        public void NotifyHandler(string message)
        {
            Notifiy?.Invoke(message);
        }
    }
}
