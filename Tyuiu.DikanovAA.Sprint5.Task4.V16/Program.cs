using Tyuiu.DikanovAA.Sprint5.Task4.V16.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V16.txt";
            Console.WriteLine("Результат: ");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
