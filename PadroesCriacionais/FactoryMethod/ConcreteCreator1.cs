namespace Factory_Method
{
    public class ConcreteCreator1: Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}