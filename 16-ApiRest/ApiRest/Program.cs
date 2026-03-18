using System.Threading.Channels;

internal class Program
{
    public static async Task Main()
    {
        const string url = "https://jsonplaceholder.typicode.com/photos/1";

        HttpClient client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync(url);
        string content = await response.Content.ReadAsStringAsync();

        Console.WriteLine("Status code: {0}", response.StatusCode);
        Console.WriteLine("Content: {0}", content);
    }
}
