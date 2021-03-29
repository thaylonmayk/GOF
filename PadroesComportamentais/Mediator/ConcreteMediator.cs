using System;
namespace Mediator
{
    public class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;
        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "A":
                    Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
                    this._component2.DoC();
                    break;
                case "D":
                    Console.WriteLine("Mediator reacts on D and triggers following operations:");
                    this._component1.DoB();
                    this._component2.DoC();
                    break;
                default:
                    Console.WriteLine("Not have actions for folowing operation");
                    break;
            }
        }

    }
}