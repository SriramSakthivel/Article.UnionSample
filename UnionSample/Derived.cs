using System;

namespace UnionSample
{
    public class Derived : Base
    {
        public static void Print()
        {
            Base b = new Base();

            //fakeDerived is not Derived,it is same Base instance typed as Derived.
            Derived fakeDerived = TypeBaseAsDerived(b);
            fakeDerived.state = 42;

            Console.WriteLine(b.GetState());//Prints 42
            Console.WriteLine(object.ReferenceEquals(b, fakeDerived));//Prints true
        }

        private static Derived TypeBaseAsDerived(Base a)
        {
            return new EvilUnion { A = a }.B;
        }
    }
}