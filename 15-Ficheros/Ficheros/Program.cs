public class Program
{
    private static string DATA_FILE = "data.txt";

    private static void WriteStream()
    {
        StreamWriter writer = new StreamWriter(DATA_FILE, true);
        writer.WriteLine("Hello World!");
        writer.Close();
    }

    private static void ReadStream()
    {
        StreamReader reader = new StreamReader(DATA_FILE);
        while (!reader.EndOfStream)
        {
            string? line = reader.ReadLine();
            Console.WriteLine(line);
        }
        reader.Close();
    }

    private static void FileExists()
    {
        bool exists = File.Exists(DATA_FILE);
        Console.WriteLine("El fichero data.txt existe: " + exists);
    }

    private static void WriteAllText()
    {
        File.WriteAllText(DATA_FILE, "Nos vamos a Japón\nY luego a Maldivas");
    }

    private static void ReadAllText()
    {
        string data = File.ReadAllText(DATA_FILE);
        Console.WriteLine("El contenido de {0} es: {1}", DATA_FILE, data);
    }

    private static void WriteAllLines()
    {
        string[] lines = "Lorem ipsum dolor sit amet consectetur adipiscing elit".Split(' ');
        File.WriteAllLines(DATA_FILE, lines);
    }

    private static void AppendAllLines()
    {
        string[] lines = "Mauris tempus neque sit amet accumsan interdum".Split(' ');
        File.AppendAllLines(DATA_FILE, lines);
    }

    private static void ReadAllLines()
    {
        string[] lines = File.ReadAllLines(DATA_FILE);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine("Linea {0}: {1}", i, lines[i]);
        }
    }
    private static void DeleteFile()
    {
        File.Delete(DATA_FILE);
    }

    public static void Main()
    {
        WriteStream();
        ReadStream();

        WriteAllText();
        ReadAllText();

        WriteAllLines();
        AppendAllLines();
        ReadAllLines();

        FileExists();
        DeleteFile();
        FileExists();
    }
}
