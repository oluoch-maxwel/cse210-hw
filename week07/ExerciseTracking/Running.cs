public class Running : Exercise
{
    private float _distance;

    public Running(DateTime date, float time, float distance)
        : base(date, time)
    {
        _distance = distance;
        _name = "Running";
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / _time) * 60;
    }
}
