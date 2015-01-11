using System;
using System.Runtime.InteropServices;

namespace UnionSample
{
    public class Base
    {
        protected int state = 123;

        public int GetState()
        {
            return state;
        }
    }

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

    [StructLayout(LayoutKind.Explicit)]
    public struct EvilUnion
    {
        [FieldOffset(0)]
        public Base A;

        [FieldOffset(0)]
        public Derived B;
    }
}