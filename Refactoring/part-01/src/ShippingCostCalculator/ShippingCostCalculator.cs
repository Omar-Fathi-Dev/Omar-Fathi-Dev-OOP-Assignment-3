namespace RefactoringLab;


public class ShippingCostCalculator
{
    public decimal Calculate(ICarrier carrier, decimal weightKg)
    {
        ArgumentNullException.ThrowIfNull(carrier);
        return carrier.CalculateCost(weightKg);
    }
}
