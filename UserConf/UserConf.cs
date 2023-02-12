namespace AkkaNetApi.UserConf;

public sealed class UserConf
{
    private UserConf() { }
    private static UserConf _instance;

    public static UserConf GetInstance()
    {
        if (_instance == null) _instance = new UserConf();
        return _instance;
    }

    public static string _salute = "";
    public static void SetSalute(string name) => _salute = $"Welcome {name}, you have been addressed by an actor";
    public static string Salute => _salute;
}