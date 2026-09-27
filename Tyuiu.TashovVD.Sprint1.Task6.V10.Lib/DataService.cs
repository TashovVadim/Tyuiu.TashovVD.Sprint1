using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.TashovVD.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            char[] separators = {' ', ',', '.'};
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (i + 1 != words.Length)
                {
                    if ((words[i].Length % 2 != 0) && (words[i].Length != 1))
                    {
                        words[i] = words[i].Remove((words[i].Length / 2), 1);
                        result += words[i] + " ";
                    }
                    else
                    {
                        result += words[i] + " ";
                    }
                }
                
                else
                {
                    if ((words[i].Length % 2 != 0) && (words[i].Length != 1))
                    {
                        words[i] = words[i].Remove((words[i].Length / 2), 1);
                        result += words[i];
                    }
                    else
                    {
                        result += words[i];
                    }
                }
            }

            return result;
        }
    }
}
