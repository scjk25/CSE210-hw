class Load
{
    public static string LoadFile(string filePath)
    {
        try
        {
            // Create a new StreamReader instance
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the entire content of the file
                string content = reader.ReadToEnd();
                return content;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while loading the file: " + ex.Message);
            return string.Empty;
        }
    }
}