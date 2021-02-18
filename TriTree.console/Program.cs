using System;
using TriTreeData.console.Structures;

namespace TriTreeData.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var tri = new TriTree();
            tri.Add("farzad");
            tri.Add("farhad");

            System.Console.WriteLine(tri.Search("reza"));
        }
    }
}
