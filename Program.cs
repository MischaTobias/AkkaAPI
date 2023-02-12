using Akka.Actor;
using AkkaNetApi.Models;
using AkkaNetApi.UserConf;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var Sys = ActorSystem.Create("the-universe");
var greeter = Sys.ActorOf<GreetingActor>("greeter");

app.MapGet("/", (string name) =>
{
    greeter.Tell(new Greet(name));
    return Results.Ok(UserConf.Salute);
});

app.Run();
