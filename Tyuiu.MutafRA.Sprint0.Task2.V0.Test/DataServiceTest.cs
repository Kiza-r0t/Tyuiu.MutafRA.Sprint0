using Tyuiu.MutafRA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MutafRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Антон";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Антон", res);
        }
    }
}
