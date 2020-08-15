using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ClassLibrary1.Class1.Str();
            ClassLibrary1.Class1.Str1();
        }
    }
}
