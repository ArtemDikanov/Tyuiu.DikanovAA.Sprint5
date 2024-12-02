using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DikanovAA.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int count = 0;
                double ress = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(".") == false)
                    {
                        res += Convert.ToInt32(line);
                        count++;
                    }
                }
                res = res / count;
               
            }
            return Math.Round(res, 3);
        }
    }
}
