// Bucle while

using System.Data.Common;

Console.WriteLine("Ejemplo while");
int num = 1;
while (num <= 10)
{
    Console.WriteLine(num);
    num++;
}

// Bucle for

Console.WriteLine("Ejemplo for");
for (int nn = 1; nn <= 10; nn++)
{
    Console.WriteLine(nn);
}

/*
Sintaxis for:

    for (variable + iniciacización ; condición-while ; incremento-variable)
    {
        // Instrucciones;
    }
*/

// Ejemplo con break;
/*
while (true)
{
    Console.Write("Dime un número (0 para terminar): ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n == 0)
    {
        break;
    }

    if (n < 0)
    {
        Console.WriteLine(n + " es negativo");
    }
    else
    {
        Console.WriteLine(n + " es positivo");
    }
}
*/

// Bucles anidados - un bucle dentro de otro

for (int i = 0; i < 5; i++)
{
    for (int j = i; j < 5; j++)
    {
        Console.WriteLine(j);
    }
}
