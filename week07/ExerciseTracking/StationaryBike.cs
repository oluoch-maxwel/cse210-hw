public class StationaryBike : Exercise
{
    private float _speed; // km/h

    public StationaryBike(DateTime date, float time, float speed)
        : base(date, time)
    {
        _speed = speed;
        _name = "Stationary Bike";
    }

    public override float GetDistance()
    {
        float km = (_time / 60) * _speed;
        return km * 0.621371f; // convert to miles
    }

    public override float GetSpeed()
    {
        return _speed * 0.621371f; // mph
    }
}
