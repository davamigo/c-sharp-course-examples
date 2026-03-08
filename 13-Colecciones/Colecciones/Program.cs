public class Program
{
    public static void Main()
    {
        /**
         Array nativo
        */

        string[] names = new string[5];
        names[0] = "Darth Vader";
        names[1] = "Luke Skywalker";
        names[2] = "Pricess Leia";
        names[3] = "Han Solo";
        names[4] = "R2D2";

        Console.WriteLine("\n--- Array");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        /**
         Collección de tipo lista
        */
        List<String> newNames = new List<string>();
        newNames.Add("Darth Vader");
        newNames.Add("Luke Skywalker");
        newNames.Add("Pricess Leia");
        newNames.Add("Han Solo");
        newNames.Add("R2D2");
        newNames.Add("C3PO");
        newNames.Add("Month Montma");

        Console.WriteLine("\n--- List");
        for (int i = 0; i < newNames.Count; i++)
        {
            Console.WriteLine(newNames[i]);
        }

        Console.WriteLine();
        foreach (string name in newNames)
        {
            Console.WriteLine(name);
        }

        /**
         Collección de pila de datos (stack) - LIFO
        */
        Stack<String> pila = new Stack<string>();
        pila.Push("Darth Vader");
        pila.Push("Luke Skywalker");
        pila.Push("Pricess Leia");
        pila.Push("Han Solo");
        pila.Push("R2D2");
        pila.Push("C3PO");
        pila.Push("Month Montma");
        pila.Pop();

        Console.WriteLine("\n--- Stack");
        foreach (string name in pila)
        {
            Console.WriteLine(name);
        }

        /**
         Collección de cola de datos (queue) - FIFO
        */
        Queue<String> cola = new Queue<string>();
        cola.Enqueue("Darth Vader");
        cola.Enqueue("Luke Skywalker");
        cola.Enqueue("Pricess Leia");
        cola.Enqueue("Han Solo");
        cola.Enqueue("R2D2");
        cola.Enqueue("C3PO");
        cola.Enqueue("Month Montma");
        cola.Dequeue();

        Console.WriteLine("\n--- Queue");
        foreach (string name in cola)
        {
            Console.WriteLine(name);
        }

        /**
         Collección de tipo conjunto (set)
        */
        HashSet<String> conjunto = new HashSet<string>();
        conjunto.Add("Darth Vader");
        conjunto.Add("Luke Skywalker");
        conjunto.Add("Pricess Leia");
        conjunto.Add("Han Solo");
        conjunto.Add("R2D2");
        conjunto.Add("C3PO");
        conjunto.Add("Month Montma");

        Console.WriteLine("\n--- HashSet");
        foreach (string name in conjunto)
        {
            Console.WriteLine(name);
        }
    }
}
