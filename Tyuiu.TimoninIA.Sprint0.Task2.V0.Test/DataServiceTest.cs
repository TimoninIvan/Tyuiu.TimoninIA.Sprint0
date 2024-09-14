namespace Tyuiu.TimoninIA.Sprint0.Task2.V0.Test
{  using Tyuiu.TimoninIA.Sprint0.Task2.V0.Lib;

 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки 
            var name = "Иван";
            var res = DataService.GetMessage(name);

        // Вызываем класс Assert и метод AreEqual
        Assert.AreEqual("Привет, Иван", res);
        }
    }
}