namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }
        public override string Operation() => $"ConcreteDecoratorA({base.Operation()})";
    }
}