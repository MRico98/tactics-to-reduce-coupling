using DecoratorPattern.Components;
using DecoratorPattern.Components.Impl;
using DecoratorPattern.Decorators;

ICoffe coffee = new SimpleCoffe();
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);

Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetCost()}");
