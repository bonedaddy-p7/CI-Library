using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void GetNowDateTimeStringTest()
        {
            CILib.CIStuff variable = new CILib.CIStuff();
            string result = variable.GetNowDateTimeString();
            Assert.False(string.IsNullOrEmpty(result.Trim()));
        }
    }
}
