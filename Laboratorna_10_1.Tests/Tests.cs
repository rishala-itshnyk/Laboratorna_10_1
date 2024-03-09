namespace Laboratorna_10_1.Tests;

public class Tests
{
    [Test]
    public void Check()
    {
        string filePath = "t.txt";
        string word = "while";
        string fileContent = "w h i l e";

        File.WriteAllText(filePath, fileContent);

        try
        {
            bool result = Program.Check(filePath, word);
            Assert.IsTrue(result, "Expected the file to contain all letters from the word 'while'.");
        }
        finally
        {
            File.Delete(filePath);
        }
    }
}