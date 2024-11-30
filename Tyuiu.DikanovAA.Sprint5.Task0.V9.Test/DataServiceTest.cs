using Tyuiu.DikanovAA.Sprint5.Task0.V9.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.DikanovAA.Sprint5\Tyuiu.DikanovAA.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists); //"C:\Users\user\source\repos\Tyuiu.DikanovAA.Sprint5\Tyuiu.DikanovAA.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt.txt"
        }
    }//
}