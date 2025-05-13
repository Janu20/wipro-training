    interface ITransport
    {
        public void Start()
        {
            Console.WriteLine("Starting the transport");
        }
        public void Stop()
        {
            Console.WriteLine("Starting the transport");
        }
    }

     class Bus : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Bus is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Bus is stopping");
        }
    }
    class Train : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Train is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Train is stopping");
        }
    }
class Program
{
 
    static void Main()
    {
        ITransport T;
        T= new Bus();

        T.Start();
        T.Stop();

        T = new Train();

        T.Start();
        T.Stop();

    }
}




