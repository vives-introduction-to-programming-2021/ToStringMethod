using System;
using System.Collections.Generic;
using System.Text;

namespace ToStringMethod
{
    public class Dog
    {
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        // Properties = Getter / Setter
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override string ToString()
        {
            return $"Dog is called {name} and is of the breed {breed}";
        }

        // Attributes
        private string name = "Hond";
        private string breed = "Poedel";
    }
}
