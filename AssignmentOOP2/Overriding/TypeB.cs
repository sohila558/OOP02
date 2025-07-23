using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP2.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        // override or hide
        // apply override
        // 1. Apply override using 'new' Keyword
        // 2. Apply override using 'override' Keyword


        // Static Binding
        // Compilor will Bind Function Call Based on Reference Type Not The Object Type
        // At Compilation
        public new void Fun01() // using new keyword
        {
            Console.WriteLine("Fun01 from TypeB");
        }

        // must be not private and virtual
        // Dynamic Binding 
        // CLR will Bind Function Call Based on Object Type Not The Reference Type
        // RunTime
        public override void Fun02() // using override keyword
        {
            Console.WriteLine($"A : {A}, B : {B}");
        }
    }
}
