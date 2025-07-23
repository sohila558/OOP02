using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP2.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int X, int Y, int z) : base(X, Y)
        {
            Z = z;
        }

        // override or hide

        public void Fun01()
        {
            Console.WriteLine("I'm Child [Derived]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X : {X}, Y : {Y}, Z : {Z}");
        }

        public override string ToString()
        {
            return $"X : {X}, Y : {Y}, Z : {Z}";
        }

    }
}
