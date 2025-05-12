using System;
class SmartDevice
{
    
    public string DeviceName;
    public bool PowerStatus ;
    
    public void TogglePower(string DeviceName, bool PowerStatus){
       
        Console.WriteLine("Device Name : "+DeviceName );
        Console.WriteLine("Power Status : "+ PowerStatus );
    }
    
}
class SmartLight : SmartDevice
{
    int Brightness;
    
    public void B(int Brightness)
    {
        Console.WriteLine("Brightness is adjusted to  : "+Brightness+ "%");
        
    }
    
    
}
class SmartThermostat : SmartDevice
{
   double Temperature; 
   
   public void T(double Temperature)
   {
         Console.WriteLine("Teperature is changed to :  "+ Temperature+" degree celsius");
   }
   
}

class Program
{
    public static void Main(string[] args)
    {
        SmartLight smartlight = new SmartLight();
        
        SmartThermostat smartthermostat = new SmartThermostat();
        
        smartlight.TogglePower("Genco",true);
        smartthermostat.T(29);
        smartlight.B(75);
        
    }
}