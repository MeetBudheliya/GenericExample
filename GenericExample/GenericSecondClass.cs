using System;
namespace GenericExample
{
    public class GenericSecondClass
    {
       public void showData<U>(U x)
        {
            Console.WriteLine(x);
        }

        public void showData<X,Y>(X x,Y y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
