using System;
class Appliance{
    public virtual void Operate(){
        Console.WriteLine("Operating");
    }
}
class WashingMachine : Appliance{
    public override void Operate(){
        Console.WriteLine("Washing Clothes");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Appliance ap = new Appliance();
        ap.Operate();
        
        WashingMachine wm = new WashingMachine();
        wm.Operate();
        
        Appliance apwm = new WashingMachine();
        apwm.Operate();
        
    }
}