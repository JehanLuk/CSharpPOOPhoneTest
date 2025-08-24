namespace Models;

class Nokia : Smarthphone
{
    public Nokia(string number, string model, string imei, int memory)
     : base(number, model, imei, memory) {}
    
    public override void InstallApp(string nameApp) 
    {
        Console.WriteLine($"Installing app {nameApp} in Nokia...");
    }
}