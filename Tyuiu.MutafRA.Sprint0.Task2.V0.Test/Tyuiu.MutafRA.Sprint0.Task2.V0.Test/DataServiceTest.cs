using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MutafRA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MutafRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService .GetMessage(name);
            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
