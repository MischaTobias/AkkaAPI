using Akka.Actor;

namespace AkkaNetApi.Models;

public class GreetingActor : ReceiveActor
{
    public GreetingActor()
    {
        Receive<Greet>(greet => UserConf.UserConf.SetSalute(greet.Who));
    }

    protected override void PreStart() => Console.WriteLine("Good Morning, we are awake!", ConsoleColor.Green);

    protected override void PostStop() => Console.WriteLine("Good Night, going to bed!", ConsoleColor.Red);
}