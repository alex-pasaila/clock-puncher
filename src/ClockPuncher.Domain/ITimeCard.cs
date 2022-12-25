namespace ClockPuncher.Domain;

public interface ITimeCard
{
    public bool Punch();
    public PunchType GetPunchState();
    public TimeSpan GetTotalAttendance();
}
