namespace AkkaNetApi.Models;

public class Greet
{
    public string Who { get; private set; }

    public Greet(string who)
    {
        Who = who;
    }
}