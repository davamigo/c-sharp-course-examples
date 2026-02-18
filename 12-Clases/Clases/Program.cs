///////////////////////////////////////////////////////////////////////////////////////////////////
// Una clase es como una plantilla o modelo que define las "características" y "comportamientos"
// que tendrán los objetos creados a partir de ella.
//
// Las "características" serán los atributos o miembros de la clase.
// Los "comportamientos" serán las funciones o métodos de la clase.
//
// Un objeto es una instancia concreta creada a partir de una clase.
//
// Por decirlo de alguna manera, una clase es como un molde y un objeto es como un pastel hecho con
// ese molde.
//

///////////////////////////////////////////////////////////////////////////////////////////////////
// Partes de la clase:

public class Coche
{
    public string marca;
    public string modelo;
    public int color;

    public Coche(string marca, string modelo, int color)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.color = color;
    }

}

///////////////////////////////////////////////////////////////////////////////////////////////////
// La clase Program y la función Main siempre existen, pero generalmente está "escondidas"

public class Program
{
    public static void Main()
    {
        ContadorDeObjetos obj1 = new ContadorDeObjetos();
        obj1.EscribirContador();
        ContadorDeObjetos obj2 = new ContadorDeObjetos();
        obj2.EscribirContador();
        ContadorDeObjetos obj3 = new ContadorDeObjetos();
        obj3.EscribirContador();
    }
}

public class ContadorDeObjetos
{
    private static int contador = 0;
    private int contador2 = 0;

    public ContadorDeObjetos()
    {
        contador++;
        contador2++;
    }

    public void EscribirContador()
    {
        Console.WriteLine("Contador: " + contador + " Contador2: " + contador2);
    }
}

