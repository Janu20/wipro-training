


using System;


abstract class SmartDevice
{
    public abstract void TurnOn();
    public void ShowStatus()
    {
        Console.WriteLine("Device status: Active");
    }
}
interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}
class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("smart light turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("lights do not support volume control");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("lights do not support volume control");
    }
}
class SmartSpeaker : SmartLight, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("smart speaker turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("volume increased");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("volume decreased");
    }
}
class Program
{
    static void Main()
    {
        SmartDevice light = new SmartLight();
        SmartDevice speaker = new SmartSpeaker();

        Console.WriteLine("");
        light.ShowStatus();
        light.TurnOn();
        ((IRemoteControl)light).IncreaseVolume();
        ((IRemoteControl)light).DecreaseVolume();

        Console.WriteLine("");
        speaker.ShowStatus();
        speaker.TurnOn();
        ((IRemoteControl)speaker).IncreaseVolume();
        ((IRemoteControl)speaker).DecreaseVolume();


    }
}