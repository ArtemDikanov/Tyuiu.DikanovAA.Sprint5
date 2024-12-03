using Tyuiu.DikanovAA.Sprint5.Task7.V11.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V11.txt";
            Console.WriteLine("Результат: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
