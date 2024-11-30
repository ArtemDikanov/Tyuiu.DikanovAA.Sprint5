using Tyuiu.DikanovAA.Sprint5.Task0.V9.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();
            Console.Write("x = " + x);//
            Console.WriteLine();
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
