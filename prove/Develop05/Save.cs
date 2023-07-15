using System.IO;

public class Save
{
    public static void SaveFile(string filePath, string content)
    {
        try
        {
            // Create a new StreamWriter instance
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the content to the file
                writer.Write(content);
            }

            Console.WriteLine("File saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while saving the file: " + ex.Message);
        }
    }
}