// Estructuras de Control - IF

Console.Write("Dime tu edad: ");
short age = Convert.ToInt16(Console.ReadLine());

if (age < 18)
    Console.WriteLine("Eres menor de edad. Fuera!");
else
    Console.WriteLine("Eres mayor de edad. Entra.");

//////////////////////////////////////////////////////////////////////////////////

if (age < 3)
{
    Console.WriteLine("Eres un bebé.");
}
else if (age < 13) // if (age >= 3 && age < 13)
{
    Console.WriteLine("Eres un niño.");
}
else if (age < 18) // if (age >= 13 && age < 18)
{
    Console.WriteLine("Eres un adolescente.");
}
else if (age < 65)
{
    Console.WriteLine("Eres un adulto.");
}
else 
{
    Console.WriteLine("Eres un viejo.");
}


/*
Sintaxis del IF:

    if (condición)
        acción-si-se-cumple;

    if (condición)
        acción-si-se-cumple;
    else
        acción-si-no-se-cumple;

    if (condición)
    {
        acción-1-si-se-cumple;
        acción-2-si-se-cumple;
        acción-3-si-se-cumple;
        ...
    }

    if (condición)
    {
        acción-1-si-se-cumple;
        acción-2-si-se-cumple;
        acción-3-si-se-cumple;
        ...
    }
    else {
        acción-1-si-no-se-cumple;
        acción-2-si-no-se-cumple;
        acción-3-si-no-se-cumple;
        ....
    }

    if (condición1)
    {
        acciones-si-se-cumple-condicion1;
    }
    else if (condición2) {
        acciones-si-no-se-cumple-condición1-pero-se-cumple-condicion2;
    }
    else {
        acciones-si-no-se-cumple-condicion1-ni-tampoco-condición2;
    }
*/

/*
Operadores de condición:

    a < b    a menor que b
    a > b    a mayor que b
    a <= b   a menor o igual que b
    a >= b   a mayor o igual que b
    a == b   a es igual que b
    a != b   a es diferente que b

    cond1 && cond2   - and - las dos tienen que ser ciertas para que se cumpla
    cond1 || cond2   - or  - una de las dos condiciones se tiene que cumplir (o las dos)
    !cond1           - not - negación: condición inversa.
*/
