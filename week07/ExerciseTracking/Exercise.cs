public abstract class Exercise
{
    protected float _time;
    protected string _name;
    protected DateTime _date;

    public Exercise(DateTime date, float time)
    {
        _date = date;
        _time = time;
    }

    public abstract float GetDistance(); // miles
    public abstract float GetSpeed();    // mph

    public float GetPace()
    {
        return _time / GetDistance(); // min per mile
    }

    public override string ToString()
    {
        return $"{_date:dd MMM yyyy} {_name} ({_time} min)- Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}