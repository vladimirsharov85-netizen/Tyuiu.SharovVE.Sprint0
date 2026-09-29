using Tyuiu.SharovVE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SharovVE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Владимир";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Владимир",res);
        }
    }
}
