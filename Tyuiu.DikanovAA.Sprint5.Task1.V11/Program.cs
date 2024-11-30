using Tyuiu.DikanovAA.Sprint5.Task1.V11.Lib;
namespace Tyuiu.DikanovAA.Sprint5.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();





        }
    }
}
