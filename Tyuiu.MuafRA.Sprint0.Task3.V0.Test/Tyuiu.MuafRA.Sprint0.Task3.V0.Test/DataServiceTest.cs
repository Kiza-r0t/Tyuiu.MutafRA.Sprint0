using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MuafRA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.MuafRA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid() => Assert.AreEqual(10, DataService.sum(5, 5));
    }
}
