namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Protected
            // Protected : a method is available in the same class or any class inherited from it (derived class)
            // we can't use it in interface 

            //class Parent
            //{
            //    protected int protectedNumber = 5;
            //}

            //class Child : Parent
            //{
            //    public void Show()
            //    {
            //        Console.WriteLine(protectedNumber);
            //    }
            //} 
            #endregion

            #region Prtected Internal
            // Prtected Internal : available in the derived classes or any class in the same project not available in interface

            /*class Parent
            {
                protected internal string name = "Sohila";
            }
            
            class child : Parent
            {
                void Show()
                {
                    Console.WriteLine(name);
                }
            }*/
            #endregion

            #region Private Protected 
            // Private Protected : available in the derived classes that exist only in the same project not available in interface

            /*class Base
            {
                private protected int age = 22;
            }
            
            class Derived : Base
            {
                void Show()
                { 
                    Console.WriteLine(age);
                }
            }*/
            #endregion

        }
    }
}
