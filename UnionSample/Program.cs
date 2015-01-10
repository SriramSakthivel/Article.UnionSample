using System;
using System.Text;

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
}
