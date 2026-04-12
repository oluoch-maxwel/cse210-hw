public class HourlyEmployee : Employee
{
    private float rate = 9;
    private float hour = 100f;

    public override float CalculatePay()
    {
        return rate * hour;
    }
}