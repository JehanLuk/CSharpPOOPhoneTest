namespace Models;

class Iphone : Smarthphone
{
    public Iphone(string number, string model, string imei, int memory)
     : base(number, model, imei, memory) {}

    public override void InstallApp(string nameApp)
    {
        Console.WriteLine($"Installing app {nameApp} in Iphone...");
    }
}