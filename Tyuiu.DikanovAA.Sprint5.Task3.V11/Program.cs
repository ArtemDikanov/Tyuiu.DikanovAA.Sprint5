using Tyuiu.DikanovAA.Sprint5.Task3.V11.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3;

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
