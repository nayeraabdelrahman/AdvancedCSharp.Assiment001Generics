using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp.Assiment001Generics
{
    internal class Car
    {
        static int id= 0;
        private string name;
        private int cost;

        public Car( string name, int cost)
        {
            this.name = name;
            this.cost = cost;
            id++;
        }

        public override string ToString() => $"Car Name: {name}, Price: {cost}";
    }
}
