class Program {

    public struct Estudiante
    {
        public string nombre;
        public string apellidos;
        public int edad;
    }

    public struct Punto
    {
        int x;
        int y;

        public Punto(int px, int py)
        {
            x = px;
            y = py;
        }

        public readonly void Dibujar()
        {
            // (x, y)
            Console.Write("(" + x + ", " + y + ")");
        }
    }

    public struct Cuadrado
    {
        Punto p1;
        Punto p2;
        Punto p3;
        Punto p4;

        public Cuadrado(Punto pp1, Punto pp2, Punto pp3, Punto pp4)
        {
            p1 = pp1;
            p2 = pp2;
            p3 = pp3;
            p4 = pp4;
        }

        public Cuadrado(int x, int y, int width, int height)
        {
            p1 = new Punto(x, y);
            p2 = new Punto(x + width, y);
            p3 = new Punto(x + width, y + height);
            p4 = new Punto(x, y + height);
        }

        public void Dibujar()
        {
            Console.Write("(");
            p1.Dibujar();
            Console.Write(", ");
            p2.Dibujar();
            Console.Write(", ");
            p3.Dibujar();
            Console.Write(", ");
            p4.Dibujar();
            Console.WriteLine(")");
        }
    }

    public static void Main() {

        Estudiante elsa = new Estudiante();
        elsa.nombre = "Elsa";
        elsa.apellidos = "A M";
        elsa.edad = 22;

        Estudiante pepe = new Estudiante();
        pepe.nombre = "Pepe";
        pepe.apellidos = "D E";
        pepe.edad = 21;

        Estudiante[] estudiantes = new Estudiante[100];
        estudiantes[0] = elsa;
        estudiantes[1] = pepe;

        Punto p1 = new Punto(10, 5);
        p1.Dibujar();
        Console.WriteLine("");

        Punto p2 = new Punto(3, 7);
        p2.Dibujar();
        Console.WriteLine("");

        Cuadrado c = new Cuadrado(10, 10, 10, 10);
        c.Dibujar();
    }
}
