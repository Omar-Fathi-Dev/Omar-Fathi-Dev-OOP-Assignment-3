namespace RefactoringLab.Carriers;

public class AramexCarrier : ICarrier
{
    private const decimal PricePerKg = 12m;

    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * PricePerKg;
    }
}

