public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int lengthMinutes, double speedKph)
        : base(date, lengthMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        return _speedKph * (LengthMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return LengthMinutes / distance; 
    }
}
