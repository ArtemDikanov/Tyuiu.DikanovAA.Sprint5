using Tyuiu.DikanovAA.Sprint5.Task5.V20.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";
            Console.WriteLine("Результат: ");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
