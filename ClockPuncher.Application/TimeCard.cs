using ClockPuncher.Domain;

namespace ClockPuncher.Application;

public class TimeCard : ITimeCard
{
    public PunchType GetPunchState() => throw new NotImplementedException();

    public TimeSpan GetTotalAttendance() => throw new NotImplementedException();

    public bool Punch() => throw new NotImplementedException();
}