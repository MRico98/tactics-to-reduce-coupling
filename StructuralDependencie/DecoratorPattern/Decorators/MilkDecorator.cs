using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public class MilkDecorator(ICoffe coffee) : CoffeeDecorator(coffee)
{
    public override string GetDescription() => $"{_coffee.GetDescription()}, milk";
    public override decimal GetCost() => _coffee.GetCost() + 0.50m;
}