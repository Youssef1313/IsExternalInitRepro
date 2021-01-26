using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int MyProperty { get; init; }
    }
}

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { } // Make it internal to fix the issue in the other project.
}