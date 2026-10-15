namespace RefactoringLab.Carriers;

public class DhlCarrier : ICarrier
{
    private const decimal PricePerKg = 18m;

    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * PricePerKg;
    }
}

