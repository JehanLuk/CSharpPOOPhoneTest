namespace Models;

public abstract class Smarthphone(string number, string model, string imei, int memory)
{
    public string Number { get; } = number;
    private string Model { get; } = model;
    private string IMEI { get; } = imei;
    private int Memory { get; } = memory;

    public void Call()
    {
        Console.WriteLine("Calling...");
    }

    public void ReceiveCall()
    {
        Console.WriteLine("Receiving call...");
    }

    public abstract void InstallApp(string nameApp);
}