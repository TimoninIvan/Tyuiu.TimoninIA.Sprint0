namespace Tyuiu.TimoninIA.Sprint0.Task3.V0.Test
{ using Tyuiu.TimoninIA.Sprint0.Task3.V0.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckValid()
    {
        Assert.AreEqual(10, DataService.Sum(5, 5));
    }
}
 }