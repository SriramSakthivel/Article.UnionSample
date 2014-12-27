using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnionSample
{
internal class Program
{
    private static void Main(string[] args)
    {
        Union union = new Union
        {
            Builder = new StringBuilder()
        };

        //text is not a string, it is StringBuilder. What the heck??
        string text = union.Text;

        //Prints some number, when I run it happens to be 25306168
        Console.WriteLine(text.Length);

        //GetType returns System.Text.StringBuilder correctly because .net 
        //stores metadata about object in itself.
        Console.WriteLine(text.GetType());

        Console.ReadLine();
    }
}

    [StructLayout(LayoutKind.Explicit)]
    public struct Union
    {
        [FieldOffset(0)]
        public StringBuilder Builder;

        [FieldOffset(0)]
        public string Text;
    }
}
