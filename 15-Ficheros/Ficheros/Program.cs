public class Program
{
    public static void Main()
    {
        StreamWriter writer = new StreamWriter("data.txt", true);
        writer.WriteLine("Hello World!");
        writer.Close();

        StreamReader reader = new StreamReader("data.txt");
        while (!reader.EndOfStream)
        {
            string? line = reader.ReadLine();
            Console.WriteLine(line);
        }
        reader.Close();
    }
}
