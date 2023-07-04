
namespace Develop02{


    public class Entry
    {   /// The responsibility of an entry is to hold a prompt, response and date.
    public string prompt;
    public string response;
    public string date;

    public Entry()
    {
        
    }
    public string ConvertToString()
    {
        return $"{date}\n{prompt}\n{response}\n";
    }

    public void Hold(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }  
    }}