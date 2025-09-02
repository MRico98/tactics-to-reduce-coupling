namespace DecoratorPattern.Components.Impl;

public class SimpleCoffe : ICoffe
{
    public decimal GetCost() => 2.00m;

    public string GetDescription() => "Simple coffe";
}