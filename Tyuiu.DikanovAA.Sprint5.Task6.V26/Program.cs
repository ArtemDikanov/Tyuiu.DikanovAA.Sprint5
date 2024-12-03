using Tyuiu.DikanovAA.Sprint5.Task6.V26.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task6.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V26.txt";
            Console.WriteLine("Результат: ");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
