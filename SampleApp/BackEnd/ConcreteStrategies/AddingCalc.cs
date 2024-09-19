
public class AddingCalc : CalcStrategy
{
    public override int Calculate(List<int> nums)
    {
        return nums.Sum();
    }
}