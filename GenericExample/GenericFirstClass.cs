using System;
namespace GenericExample
{
    public class GenericFirstClass<T>
    {

        private T x;

        public T X{
            set
            {
                x = value;
            }
        }


        public void printData()
        {
            Console.WriteLine(x);
        }

        public T getData()
        {
            return x;
        }
    }
}
