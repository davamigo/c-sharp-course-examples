const int maxRobots = 50;
int totalRobots = 0;
Robot[] robots = new Robot[maxRobots];

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
    Console.WriteLine("");
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
    Console.WriteLine("");
}

Robot NuevoRobotAleatorio()
{
    Robot nuevoRobot = null;
    string nombre = NombreAleatorio();
    string modelo = ModeloAleatorio();
    switch (modelo)
    {
        case "R2D2":
            nuevoRobot = new R2D2(nombre, 0);
            break;
        case "C3PO":
            nuevoRobot = new C3PO(nombre, 1000);
            break;
        case "BB8":
            nuevoRobot = new BB8(nombre, 100);
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

int PedirPosicion()
{
    Console.Write("Que posición: ");
    int posicion = Convert.ToInt32(Console.ReadLine());
    if (posicion < 0 || posicion >= maxRobots)
    {
        Console.WriteLine("Posición " + posicion + " inválida");
        return -1;
    }
    else if (robots[posicion] == null)
    {
        Console.WriteLine("Posición " + posicion + " vacía");
        return -1;
    }
    else
    {
        return posicion;
    }
}

void RestablecerRobot()
{
    Console.WriteLine("");
    int posicion = PedirPosicion();
    if (posicion >= 0)
    {
        Robot robotRestablecido = NuevoRobotAleatorio();
        robots[posicion] = robotRestablecido;
        Console.Write("Robot restablecido");
        DibujarRobot(robotRestablecido);
    }
    Console.WriteLine("");
}

void VerRobot()
{
    Console.WriteLine("");
    int posicion = PedirPosicion();
    if (posicion >= 0)
    {
        Console.Write("Robot num. " + posicion);
        DibujarRobot(robots[posicion]);
    }
    Console.WriteLine("");
}

void EliminarRobot()
{
    Console.WriteLine("");
    int posicion = PedirPosicion();
    if (posicion >= 0)
    {
        robots[posicion] = null;
        Console.WriteLine("Robot " + posicion + " borrado");
    }
    Console.WriteLine("");
}

void ListarRobots()
{
    Console.WriteLine("");
    Console.WriteLine("Lista de robots:");
    for (int i = 0; i < totalRobots; i++)
    {
        if (robots[i] != null) {
            Console.Write("Robot num. " + i);
            DibujarRobot(robots[i]);
        }
    }
    Console.WriteLine("");
    return;
}
