namespace Tyuiu.TimoninIA.Sprint0.Task2.V0.Test
{  using Tyuiu.TimoninIA.Sprint0.Task2.V0.Lib;

 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // ������� �������� ������� ������������, ������� �� ���������� 
            var name = "����";
            var res = DataService.GetMessage(name);

        // �������� ����� Assert � ����� AreEqual
        Assert.AreEqual("������, ����", res);
        }
    }
}