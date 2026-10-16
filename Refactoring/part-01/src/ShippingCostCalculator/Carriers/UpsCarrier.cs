namespace RefactoringLab.Carriers;

public class UpsCarrier : ICarrier
{
    private const decimal PricePerKg = 20m;

    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * PricePerKg;
    }
}