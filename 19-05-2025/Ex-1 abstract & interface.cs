 abstract class SmartDevice
  {
      public abstract void TurnOn();

      public void ShowStatus()
      {
          Console.WriteLine("Device status Active");
      }
  }
  namespace ConsoleApp1
{
    interface IRemoteControl
    {
       public void IncreaseVolume();

        public void DecreaseVolume();
    }
}
     class SmartLight : SmartDevice , IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Light turned on");
        }
    public void IncreaseVolume()
    {
    Console.WriteLine("Lights do not support volume controls");
    }

public void DecreaseVolume()
{
    Console.WriteLine("Lights do not support volume controls");
}


    }
    internal class SmartSpeaker : SmartDevice,IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart speaker is turned on");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Volume increased");
        }
        public void DecreaseVolume()
        {
            Console.WriteLine("Volume decreased");
        }
    }
    class Program
    {

        public static void Main()
        {
            SmartDevice SD;
            SD  = new SmartSpeaker();

            SD.TurnOn();
            IRemoteControl remoteControl;
            remoteControl = new SmartSpeaker();


            remoteControl.IncreaseVolume();
                remoteControl.DecreaseVolume();
            

            SD = new SmartLight();

           

            SD.TurnOn();
            IRemoteControl remoteControl1;
            remoteControl1 = new SmartLight();


            remoteControl1.IncreaseVolume();
            remoteControl1.DecreaseVolume();






        }
    }
