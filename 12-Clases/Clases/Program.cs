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

using System.ComponentModel;

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
        /*
        ContadorDeObjetos obj1 = new ContadorDeObjetos();
        obj1.EscribirContador();
        ContadorDeObjetos obj2 = new ContadorDeObjetos();
        obj2.EscribirContador();
        ContadorDeObjetos obj3 = new ContadorDeObjetos();
        obj3.EscribirContador();
        */

        /*
        Person p1 = new Person();
        Person p2 = new ("Luke", "Skywalker", 20);
        Person p3 = new Person (p2);
        Person p4 = p3;
        p4.FirstName = "Pepe";
        */

        /*
        BankAccount account = new BankAccount("ING", 40000);
        account.Deposit(1000);
        Console.WriteLine(account.Balance);
        */

        /*
        Vehicle vehicle = new("Mercedes", "Clase A", 2019);
        vehicle.DisplayData();

        Car car = new Car("Mercedes", "Clase A", 2019, 5);
        car.DisplayData();

        Van van = new Van("Citroen", "Berlingo", 1999, 1500);
        van.DisplayData();
        */

        BookList books = new BookList(100);
        BookList.Book book1 = new BookList.Book("Miguel de Cervantes", "Don Quijote");
        books.Add(book1);
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////
// static

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


///////////////////////////////////////////////////////////////////////////////////////////////////
// Ejemplo de clase

class Person
{
    public string? FirstName { get; set; }
    public string? FamilyName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string familyName, int age)
    {
        FirstName = firstName;
        FamilyName = familyName;
        Age = age;
    }
    public Person()
    {
        FirstName = null;
        FamilyName = null;
        Age = 0;
    }
    public Person(Person other)
    {
        FirstName = other.FirstName;
        FamilyName = other.FamilyName;
        Age = other.Age;
    }
}


///////////////////////////////////////////////////////////////////////////////////////////////////
// Ejemplo de clase

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}


///////////////////////////////////////////////////////////////////////////////////////////////////
// Herencia

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public virtual void DisplayData()
    {
        Console.WriteLine("Marca: " + Brand + ", Modelo: " + Model + ", Año: " + Year);
    }
}

public class Car : Vehicle
{
    public int Doors { get; set; }

    public Car(string brand, string model, int year, int doors) : base(brand, model, year)
    {
        Doors = doors;
    }

    public override void DisplayData()
    {
        Console.Write("Tipo: Coche, Puertas: " + Doors + ", ");
        base.DisplayData();
    }
}

public class Van : Vehicle
{
    public int MaxLoadKg { get; set; }

    public Van(string brand, string model, int year, int maxLoadKg) : base(brand, model, year)
    {
        MaxLoadKg = maxLoadKg;
    }

    public override void DisplayData()
    {
        Console.Write("Tipo: Furgoneta, Carga Max.: " + MaxLoadKg + ", ");
        base.DisplayData();
    }
}


///////////////////////////////////////////////////////////////////////////////////////////////////
// Clases dentro de clases

class BookList
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

    }
    private Book[] data;
    private int size;
    public BookList(int count)
    {
        data = new Book[count];
        size = 0;
    }
    public void Add(Book book)
    {
        data[size++] = book;
    }
    public Book GetAt(int pos)
    {
        return data[pos];
    }
}
