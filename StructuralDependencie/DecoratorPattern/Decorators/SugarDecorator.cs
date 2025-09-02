using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public class SugarDecorator(ICoffe coffee) : CoffeeDecorator(coffee)
{
    public override string GetDescription() => $"{_coffee.GetDescription()}, sugar";
    public override decimal GetCost() => _coffee.GetCost() + 0.25m;
}