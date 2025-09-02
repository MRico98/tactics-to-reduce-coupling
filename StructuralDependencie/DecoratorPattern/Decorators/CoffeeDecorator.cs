using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public abstract class CoffeeDecorator(ICoffe coffee) : ICoffe
{
    protected ICoffe _coffee = coffee;

    public virtual decimal GetCost() => _coffee.GetCost();

    public virtual string GetDescription() => _coffee.GetDescription();
}