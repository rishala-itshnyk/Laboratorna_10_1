using System;
using System.IO;

public class Program
{
    static void Main()
    {
        string filePath = "t.txt";

        bool result = Check(filePath, "while");

        Console.WriteLine("В файлі є всі букви зі слова 'while': " + result);
    }

    public static bool Check(string filePath, string word)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);

            foreach (char letter in word)
            {
                if (fileContent.IndexOf(letter) == -1)
                {
                    return false;
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
            return false;
        }
    }
}