using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DikanovAA.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7V11.txt" }); //string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != ' ') && (line[i] != 'а') && (line[i] != 'б') && (line[i] != 'в') && (line[i] != 'г') && (line[i] != 'д') && (line[i] != 'е') && (line[i] != 'ё') && (line[i] != 'ж') && (line[i] != 'з') && (line[i] != 'и') && (line[i] != 'й') && (line[i] != 'к') && (line[i] != 'л') && (line[i] != 'м') && (line[i] != 'н') && (line[i] != 'о') && (line[i] != 'п') && (line[i] != 'р') && (line[i] != 'с') && (line[i] != 'т') && (line[i] != 'у') && (line[i] != 'ф') && (line[i] != 'х') && (line[i] != 'ц') && (line[i] != 'ч') && (line[i] != 'ш') && (line[i] != 'щ') && (line[i] != 'ъ') && (line[i] != 'ы') && (line[i] != 'ь') && (line[i] != 'э') && (line[i] != 'ю') && (line[i] != 'я'))
                        {
                            if (i == 16 || i == 35 || i == 37)
                            {
                                strLine = strLine + line[i] + " ";
                            }
                            else
                            {
                                strLine = strLine + line[i];
                            }
                        }

                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
