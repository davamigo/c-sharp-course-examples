const int maxRobots = 10;
int totalRobots = 0;
Robot[] robots = new Robot[maxRobots];

void DibujarMenu()
{
    Console.WriteLine("---------------------");
    Console.WriteLine("1. Generar Robot");
    Console.WriteLine("2. Restablecer Robot");
    Console.WriteLine("3. Ver Robot");
    Console.WriteLine("4. Eliminar Robot");
    Console.WriteLine("5. Listar Robots");
    Console.WriteLine("0. Salir");
    Console.Write("Opción: ");
}

void CrearRobot()
{
    if (totalRobots >= maxRobots)
    {
        Console.WriteLine("No caben más robots");
    }
    else {
        Robot nuevoRobot = NuevoRobotAleatorio();
        if (nuevoRobot != null)
        {
            robots[totalRobots++] = nuevoRobot;
            Console.Write("Robot Creado");
            DibujarRobot(nuevoRobot);
        }
    }
}

Robot NuevoRobotAleatorio()
{
    Robot nuevoRobot = null;
    string nombre = NombreAleatorio();
    string modelo = ModeloAleatorio();
    switch (modelo)
    {
        case "R2D2":
            nuevoRobot = new R2D2(nombre);
            break;
        case "C3PO":
            nuevoRobot = new C3PO(nombre);
            break;
        case "BB8":
            nuevoRobot = new BB8(nombre);
            break;
    }
    return nuevoRobot;
}

void DibujarRobot(Robot robot)
{
    Console.Write(": Modelo " + robot.ObtenerModelo());
    Console.Write(" - Nombre " + robot.ObtenerNombre());
    Console.WriteLine("");

}

string NombreAleatorio()
{
    var rand = new Random();
    string nombre = "";
    for (int i = 0; i < 2; i++)
    {
        nombre += (char)rand.Next('A', 'Z');
    }
    for (int i = 0; i < 3; i++)
    {
        nombre += (char)rand.Next('0', '9');
    }
    return nombre;
}

string ModeloAleatorio()
{
    var rand = new Random();
    string[] modelos = ["R2D2", "C3PO", "BB8"];
    return modelos[rand.Next(0, 2)];
}

void RestablecerRobot()
{
    // TODO
}

void VerRobot()
{
    // TODO
}

void EliminarRobot()
{
    // TODO
}

void ListarRobots()
{
    for (int i = 0; i < totalRobots; i++)
    {
        Console.Write("Robot num. " + (i + 1));
        DibujarRobot(robots[i]);
    }
}

string opcion;
do
{
    DibujarMenu();
    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            CrearRobot();
            break;

        case "2":
            RestablecerRobot();
            break;

        case "3":
            VerRobot();
            break;

        case "4":
            EliminarRobot();
            break;

        case "5":
            ListarRobots();
            break;
    }
}
while (opcion != "0");
