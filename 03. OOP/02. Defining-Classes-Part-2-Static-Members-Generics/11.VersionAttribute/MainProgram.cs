/*
Problem 11. Version attribute
• Create a  [Version]  attribute that can be applied to structures, classes, 
interfaces, enumerations and methods and holds a version in the format  major.minor  (e.g.  2.11 ).
• Apply the version attribute to a sample class and display its version at runtime.
*/
using System;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum |
        AttributeTargets.Method,
        AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }

    [Version(3, 4)]
    class Attributes
    {
        static void Main()
        {
            Type type = typeof(Attributes);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine("This class is version number {0}.{1}. ", item.Major,item.Minor);
            }
        }
    }
}