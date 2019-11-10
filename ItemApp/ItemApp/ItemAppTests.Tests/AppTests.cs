using ItemApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ItemAppTests.Tests
{
    [TestClass]
    public class AppTests
    {
        private List<string> output = new List<string>();

        [TestMethod]
        public void TestRunApp()
        {
            var app = new App(WriteLine);

            app.Run();

            Assert.AreEqual("Item Number\t: 1111", output[0] );
            Assert.AreEqual("Item\t\t: Water", output[1] );
            Assert.AreEqual("Unit of Measure\t: GALLON", output[2]);
            Assert.AreEqual("Weight\t\t: 5", output[3]);
        }

        private void WriteLine(string s)
        {
            output.Add(s);
        }
    }
}
