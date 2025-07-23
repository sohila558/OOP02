using AssignmentOOP2.Inheritance;
using AssignmentOOP2.Overriding;

namespace AssignmentOOP2
{
    internal class Program
    {
        //static int sum(int x, int y, int z)
        //{
        //    return x + y;
        //}

        //static int sum(int x, int y)
        //{
        //    return x + y;
        //}

        //static double sum(double x, int y)
        //{
        //    return x + y;
        //}

        //static double sum(double x, double y)
        //{
        //    return x + y;
        //}


        static void Main(string[] args)
        {
            #region Inheritance
            // 2. Inheritance : 
            // X --> Y
            // DRY


            //Parent parent = new Parent(1, 2);

            // Console.WriteLine(parent);

            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1, 2, 3);

            //child.Fun01();
            //child.Fun02(); 
            #endregion

            #region Polymorphism
            // 3. Polymorphism
            // 3.1. Polymorphism Methods (Functions) Overloading
            // 3.2. Polymorphism Methods (Functions) Overriding


            // Console.WriteLine();

            #endregion

            #region 3.1. Polymorphism Methods (Functions) Overloading

            // 3.1. Polymorphism Methods (Functions) Overloading

            // there is are more than one function(in the same scope [class - struct])
            // these function have the same name but with different signature
            // (count - type - order) parameters

            // sum(1, 2);
            // sum(1.3, 1.4);

            //sum(1.3, 3.4);  
            #endregion

            #region 3.2. Polymorphism Methods (Functions) Overriding

            // there are more than one function [in different classes] these function have the same name
            // and the same signature but with different behavior

            TypeB typeB = new TypeB() { A = 12, B = 13 };

            //typeB.A = 12;
            //typeB.B = 13;

            Console.WriteLine(typeB.A);
            Console.WriteLine(typeB.B);

            typeB.Fun01();
            typeB.Fun02();

            #endregion

        }
    }
}
