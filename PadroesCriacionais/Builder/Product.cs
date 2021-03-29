using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part) => this._parts.Add(part);

        public string ListParts()
        {
            string str = string.Empty;

            foreach (object v in this._parts)
            {
                str += v + ", ";
            }
            str = str.Remove(str.Length - 2); // removing last ",c"
            return "Product parts: " + str + "\n";
        }
    }
}