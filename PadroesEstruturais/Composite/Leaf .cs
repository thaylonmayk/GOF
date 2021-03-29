namespace Composite
{
    public class Leaf : Component
    {
        public override string Operation() => "Leaf";

        public override bool IsComposite() => false;
    }
}