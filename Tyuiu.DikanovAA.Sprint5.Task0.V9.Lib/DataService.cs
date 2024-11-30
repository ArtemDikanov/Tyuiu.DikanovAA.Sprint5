using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.DikanovAA.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });                                                            //$@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = Math.Round( (Math.Pow(x, 3) / (Math.Pow(x, 2) - 1)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
