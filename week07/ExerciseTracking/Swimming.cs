public class Swimming : Exercise
{
    private float _laps;

    public Swimming(DateTime date, float time, float laps)
        : base(date, time)
    {
        _laps = laps;
        _name = "Swimming";
    }

    public override float GetDistance()
    {
        float meters = _laps * 50;
        return meters / 1609f; // meters → miles
    }

    public override float GetSpeed()
    {
        return (GetDistance() / _time) * 60;
    }
}