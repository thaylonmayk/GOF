using System;
namespace Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;
        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }
        public string GetState() => this._state;
        public string GetName() => $"{this._date} / ({this._state.Substring(0, 9)})...";
        public DateTime GetDate() => this._date;
    }
}