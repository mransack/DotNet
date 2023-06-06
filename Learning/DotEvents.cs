namespace Learning
{
    public class DotEvents
    {
        public static void DemoCustomEvents()
        { 
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("sub 1", pub);
            Subscriber sub2 = new Subscriber("sub 2", pub);

            pub.DoSomething();

        }
    }


    //Events - Custom
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
    }

    public class Subscriber
    {
        public readonly string _id;

        public Subscriber(string id, Publisher pub)
        {
            _id = id;
            pub.CustomEvent += HandleCustomEvent;
        }
        public void HandleCustomEvent(object sender, CustomEventArgs e) 
        {
            //Console.Write(sender);
            Console.WriteLine($"{_id} received this message: {e.Message}");
        }
    }
    public class Publisher
    {
        public event EventHandler<CustomEventArgs> CustomEvent;

        public string id = "1";

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Event triggered"));
        }

        public virtual void OnRaiseCustomEvent(CustomEventArgs e) 
        {
            EventHandler<CustomEventArgs> handler = CustomEvent;
            if (handler != null)
            {
                e.Message += $"at {DateTime.Now}";
                handler(this, e);
            }
        }

    }
}
