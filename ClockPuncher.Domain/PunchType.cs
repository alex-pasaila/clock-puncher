namespace ClockPuncher.Domain;

public class PunchType
{
    private readonly string _value;

    private PunchType(string value)
    {
        _value = value;
    }

    public static PunchType In() => new("IN");
    public static PunchType Out() => new("OUT");

    public override string ToString()
    {
        return _value;
    }
}
