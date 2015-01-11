using System.Runtime.InteropServices;

namespace UnionSample
{
    [StructLayout(LayoutKind.Explicit)]
    public struct EvilUnion
    {
        [FieldOffset(0)]
        public Base A;

        [FieldOffset(0)]
        public Derived B;
    }
}