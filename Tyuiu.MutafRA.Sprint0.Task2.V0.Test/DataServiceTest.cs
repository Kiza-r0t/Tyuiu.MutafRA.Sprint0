using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MutafRA.Sprint0.Task2.V0.Lib;


namespace Tyuiu.MutafRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void checkGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);
        }
    }
}
