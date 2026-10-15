namespace RefactoringLab.Carriers;

public class FedExCarrier : ICarrier
{
private const decimal PricePerKg = 15m;

public decimal CalculateCost(decimal weightKg)
{
    return weightKg * PricePerKg;
}
}

