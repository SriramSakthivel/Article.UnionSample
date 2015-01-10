using System.Runtime.InteropServices;
using System.Text;

namespace UnionSample
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Union
    {
        [FieldOffset(0)]
        public StringBuilder Builder;

        [FieldOffset(0)]
        public string Text;
    }
}