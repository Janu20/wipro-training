// interface class

interface IDeviceControl
{
    public void TurnOn();
    public void TurnOff();
}

//class 1

 class SmartTv : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("SmartTV is now ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("SmartTV is now OFF");
    }
}

//class 2 

class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Speaker is now ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("Speaker is now OFF");
    }
}

// main claa

    public static void Main()
    {

        IDeviceControl ID = new SmartTv(); 
        Speaker ID1 = new Speaker();

        ID1.TurnOn();
        ID1.TurnOff();

        ID.TurnOn();
        ID.TurnOff();




    }

