using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericFirstClass<int> intTest = new GenericFirstClass<int>();
            intTest.X = 22;
            intTest.printData();
            Console.WriteLine(intTest.getData());
            Console.ReadKey();


            GenericFirstClass<float> floatTest = new GenericFirstClass<float>();
            floatTest.X = (float)22.20;
            floatTest.printData();
            Console.WriteLine(floatTest.getData());
            Console.ReadKey();

        }

        static void Main1(string[] args)
        {
            GenericSecondClass test2 = new GenericSecondClass();
            test2.showData<int>(33);

            Console.ReadKey();
        }
    }
}
